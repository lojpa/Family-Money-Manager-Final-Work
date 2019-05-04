using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Repositories
{
    public interface IUserRepository
    {
        User Get(int id);
        User Create(User user);
        UserLogin GetUser(UserLogin user);
    }
}
