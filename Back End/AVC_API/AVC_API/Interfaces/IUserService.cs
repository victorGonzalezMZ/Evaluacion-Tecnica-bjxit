using AVC_API.Models;

namespace AVC_API.Interfaces
{
    public interface IUserService
    {
        Task<User> Login(string user, string pass);
        Task<List<User>> GetAllUsers();
        Task<User> GetUser(string UserID);
        Task<bool> AddUser(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(User user);
    }
}
