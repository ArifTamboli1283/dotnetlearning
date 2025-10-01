
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capstone_web_api.Entities;


namespace Capstone_web_api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<User> _users;
    public UserRepository(MongoDbHelper dbHelper)
    {
        _users = dbHelper.GetCollection<User>("Users");
    }

    public async Task<IEnumerable<User>> getAllUser()
    {
        return await _users.Find(user => true).ToListAsync();
    }
    public async Task AddUserAsync(User user)
    {
        await _users.InsertOneAsync(user);
    }

    public async Task UpdateUser(User user)
    {
        await _users.ReplaceOneAsync(u => u.Id == user.Id, user);
    }


    public async Task DeleteUser(User user)
    {
        await _users.DeleteOneAsync(u => u.Id == user.Id);
    }


    public async Task<User> GetById(int id)
    {
        return await _users.Find(u => u.Id == id).FirstOrDefaultAsync();
    }

}