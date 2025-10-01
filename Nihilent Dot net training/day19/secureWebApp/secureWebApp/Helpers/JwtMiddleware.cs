using System.IdentityModel;

namespace SecureWebApp.Helpers;

public class JwtMiddleWare
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;

    public JwtMiddleWare(RequestDelegate next, IOption<AppSettAppSettings> appSettings)
    {

    }
    public async Task Invoke(HttpContext context, IUserService userService)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.split(" ").Last;
        if (token != null)
        {
            attachUserToContext(context, userService, token);
        }
        await _next(context);
    }

    private void attachUserToContext(HttpContext context, IUserService userService, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningkey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssues = false,
                ValidateAudience = false,
                clockSkew = TimeSpan.Zero
            }, out Secuirity validateToken);
            var jwtToken = (JwtSecurityToken)validateToken;
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);
            context.Items["User"] = userService.GetById(userId);
        } catch {}
    }
}