using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment.Data.UserMemory;
using Assignment.Model;
using Microsoft.AspNetCore.Http;

namespace Assignment.Data.UserMemory
{
    public class UserWebServices : IUserServices
    {
        public async Task<User> ValidateUser(string userName, string password)
        {
            HttpClient client = new HttpClient();
            Task<string> stringAsync =
                client.GetStringAsync($"https://localhost:5003/User?username={userName}&password={password}");
            string userAsJson = await stringAsync;
            var finalUser = JsonSerializer.Deserialize<User>(userAsJson,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });

            return finalUser;
        }
    }
}