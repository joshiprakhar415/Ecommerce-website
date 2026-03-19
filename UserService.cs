using Ecommerce.Interfaces;
using Ecommerce.Models;
using Ecommerce.Repository;

namespace Ecommerce.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repo;

        public UserService(UserRepository repo)
        {
            _repo = repo;
        }

        public User? Register(User user)
        {
            return _repo.Add(user);
        }

        public User? Login(string username, string password)
        {
            var user = _repo.GetByUsername(username);

            if (user == null)
                return null;

            if (user.PasswordHash != password)
                return null;

            return user;
        }
    }
}