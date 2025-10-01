using Capstone_web_api.Entities;

namespace Capstone_web_api.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> getAllUser();
    // Task<User> UserLogin(string userName, string Password);
    Task AddUserAsync(User user);
    Task UpdateUser(User user);
    Task DeleteUser(User user);
    Task<User> GetById(int id);
}