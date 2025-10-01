using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Text;
using Capstone_web_api.Services;
namespace Capstone_web_api.Helpers;

public class JwtMiddleWare
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;
    public JwtMiddleWare(RequestDelegate next, IOptions<AppSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;
    }

    public async Task Invoke(HttpContext httpContext, IUserService userService)
    {
        var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        if (token != null)
        {
            attachUserContext(httpContext, userService, token);
        }
        await _next(httpContext);
    }

    private void attachUserContext(HttpContext httpContext, IUserService userService, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken ValidationToken);
            var jwtToken = (JwtSecurityToken)ValidationToken;
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);
            httpContext.Items["User"] = userService.GetById(userId);
        }
        catch
        {

        }
    }
}