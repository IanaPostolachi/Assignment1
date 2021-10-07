using Assignment.Model;

namespace Assignment.Data.UserMemory
{
    public interface IUserServices
    {
        User ValidateUser(string userName, string password);
    }
}