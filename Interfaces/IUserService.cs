using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Interfaces
{
    public interface IUserService
    {
        User Get(int id);
        User Create(User user);
        UserLogin Login(UserLogin userLogin);
    }
}
