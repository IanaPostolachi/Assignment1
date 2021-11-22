using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApi.Model;
using WebApi.Persistence;

namespace WebApi.Data.UserMemory
{
    public class UserDBServices : IUserServices
    {
        private AdultDBContext AdultDbContext;

        public UserDBServices(AdultDBContext adultDbContext)
        {
            AdultDbContext = adultDbContext;
        }
        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = await AdultDbContext.Users.FirstOrDefaultAsync(user => user.UserName.Equals(userName) && user.Password.Equals(password));
            if (first != null)
            {
                Console.WriteLine(first.City);
                return first;
            }
            throw new Exception("User not found");
        }
        
        public async Task<User> AddUserAsync(User user)
        {
            EntityEntry<User> addedUser = await AdultDbContext.Users.AddAsync(user);
            Console.WriteLine("New user!!!" + addedUser.Entity);
            await AdultDbContext.SaveChangesAsync();
            return addedUser.Entity;
        }
    }
}