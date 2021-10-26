using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Data.UserMemory
{
    public class UserServices : IUserServices
    {
        private ICollection<User> users;

        public UserServices()
        {
            users = new[]
            {
                new User()
                {
                    UserName = "Iana123",
                    Password = "Iana123",
                    BirthYear = 2001,
                    City = "Horsens",
                    Role = "Admin"
                },
                new User()
                {
                    UserName = "Ana123",
                    Password = "Ana123",
                    BirthYear = 1999,
                    City = "Horsens",
                    Role = "User"
                },
                new User()
                {
                    UserName = "Andrei123",
                    Password = "Andrei123",
                    BirthYear = 2001,
                    City = "Horsens",
                    Role = "User"
                }
            }.ToList();
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName) && user.Password.Equals(password));
            if (first != null)
            {
                Console.WriteLine(first.City);
                return first;
            }
            throw new Exception("User not found");
        }
    }
}