using Capstone_web_api.Repositories;
using Capstone_web_api.Entities; 
using Capstone_web_api.Models; 


namespace Capstone_web_api.Services;

public interface IUserService
{
    Task<IEnumerable<User>> getAllUser();
    // Task<User> UserLogin(string userName, string Password);
    Task AddUserAsync(User user);
    Task UpdateUser(User user);
    Task DeleteUser(User user);
    Task<User> GetById(int id);
    Task<AuthenticateResponse> Authenticate(AuthenticateRequest request);
}