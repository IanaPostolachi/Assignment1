using System;
using System.Collections.Generic;
using System.Linq;
using Assignment.Model;

namespace Assignment.Data.UserMemory
{
    public class UserServices : IUserServices
    {
        private List<User> users;

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

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            return first;
        }
    }
}