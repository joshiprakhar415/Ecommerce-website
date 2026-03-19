using Ecommerce.Models;

namespace Ecommerce.Interfaces
{
    public interface IUserService
    {
        User? Register(User user);
        User? Login(string username, string password);
    }
}