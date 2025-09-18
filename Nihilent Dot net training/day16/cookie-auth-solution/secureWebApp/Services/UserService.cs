using Microsoft.AspNetCore.Mvc;
using secureWebApp.Models;

namespace SecureWebApp.Services
{
    public class UserService
    {
        public List<User> users;
        public UserService() { 
            users = new List<User>();
            users.Add(new User { Email="ariftamboli@gmail.com", Password="123Arif" });
            users.Add(new User { Email = "arif1993@gmail.com", Password = "arif123" });
        }  
        
        public User Validate(string email, string password)
        {
            return users.FirstOrDefault(user=>user.Email == email && user.Password == password);
        }
    }
}