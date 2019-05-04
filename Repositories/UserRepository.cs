using FamilyMoneyManagerApp.Context;
using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FamilyMoneyManagerContext _context;

        public UserRepository(FamilyMoneyManagerContext context)
        {
            _context = context;
        }

        public User Get(int id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();

            if (user == null)
                return null;

            return user;
        }

        public User Create(User user)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                user.Password = hash;
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserLogin GetUser(UserLogin userLogin)
        {

            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(userLogin.Password));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                userLogin.Password = hash;
            }

            var user = _context.Users.Where(x => x.UserName == userLogin.UserName && x.Password == userLogin.Password).FirstOrDefault();

            UserLogin login = new UserLogin();
            login.UserName = userLogin.UserName;
            login.Password = userLogin.Password;

            if (user == null)
                return null;

            return login;
        }
    }
}
