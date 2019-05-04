using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User user)
        {
            var createdUser = _userRepository.Create(user);
            return createdUser;
        }

        public User Get(int id)
        {
            var user = _userRepository.Get(id);
            return user;
        }

        public UserLogin Login(UserLogin userLogin)
        {
            var user = _userRepository.GetUser(userLogin);
            return user;
        }
    }
}
