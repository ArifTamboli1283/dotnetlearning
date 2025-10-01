using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

using Capstone_web_api.Repositories;
using Capstone_web_api.Entities;
using Capstone_web_api.Models;
using Capstone_web_api.Helpers;


namespace Capstone_web_api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly AppSettings _appSettings;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<IEnumerable<User>> getAllUser()
    {
        return await _userRepository.getAllUser();
    }

    // public async Task<User> UserLogin(string userName, string Password)
    // {
    //     return await _userRepository.UserLogin(userName, Password);
    // }

    public async Task AddUserAsync(User user)
    {
        await _userRepository.AddUserAsync(user);
    }
    public async Task UpdateUser(User user)
    {
        await _userRepository.UpdateUser(user);
    }
    public async Task DeleteUser(User user)
    {
        await _userRepository.DeleteUser(user);
    }

    public async Task<User> GetById(int id)
    {
        return await _userRepository.GetById(id);
    }

    public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest request)
    {

        var users = await _userRepository.getAllUser(); // Await the task first
        var user = users.SingleOrDefault(x =>
            x.UserName == request.UserName &&
            x.Password == request.Password);

        if (user == null)
        {
            return null;
        }

        var token = generateJwtToken(user);
        return new AuthenticateResponse(user, token);

    }

    private string generateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("DSFDSFDSJFJDSKFNDSNFNDSJFNJDNSFKNSDNFDSNFKNSDFNDJS");
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), 
                                                            SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}