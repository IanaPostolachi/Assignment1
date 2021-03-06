using System.Threading.Tasks;
using Assignment.Model;

namespace Assignment.Data.UserMemory
{
    public interface IUserServices
    {
        Task<User> ValidateUser(string userName, string password);
    }
}