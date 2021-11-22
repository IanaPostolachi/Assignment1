using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Data.UserMemory
{
    public interface IUserServices
    {
        Task<User> ValidateUser(string userName, string password);
        Task<User> AddUserAsync(User user);
    }
}