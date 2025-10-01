using System.Collections.Generic;
using SecureWebApp.Entities;
using SecureWebApp.Models;

namespace SecureWebApp.Services;

public interface IUserService
{
    //DTO Data transfer object
    AuthenticateResponse Authenticate(AuthenticateRequest model);
    IEnumerable<User> Getall();
    User GetUserById(int id);
}