using System.Collections.Generic;
using SecureWebApp.Entities;
using SecureWebApp.Models;

namespace SecureWebApp.Services;

public class userService : IUserService
{
    private List<User> _users = new List<User>
    {
        new User { Id = "1", FirstName = "", LastName = "", UserName = "" , Password = ""},
          new User { Id = "1", FirstName = "", LastName = "", UserName = "" , Password = ""},
            new User { Id = "1", FirstName = "", LastName = "", UserName = "" , Password = ""},
              new User { Id = "1", FirstName = "", LastName = "", UserName = "" , Password = ""},
    };
    private readonly AppSettings _appSetting;

    public AuthenticateResponse Authenticate(AuthenticateRequest model)
    {
        var user = _users.SingleOrDefault(x => x.UserName = model.UserName && x.Password == model.Password);
        if (user == null)
        {
            return null;
        }
        var token = generateJwtToken(user);
        return new AuthenticateResponse(user, token);
    }

    public IEnumerable<User> GellAll()
    {
        return _users;
    }
    private string generateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("_appSettings.Secret");
        var tokenDescription = new SeccurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecuirity(key), SecuriryAlgorithms.HashSha256Signature)
        };
        var token = tokenHandler.GenerateToken(tokenDescription);
        return tokenHandler.WritToken(token);
    }
}