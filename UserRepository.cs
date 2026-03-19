using Ecommerce.Data;
using Ecommerce.Models;
using System.Linq;

namespace Ecommerce.Repository
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User? GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username);
        }

    }
}