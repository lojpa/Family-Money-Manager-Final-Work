using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Services
{
    public interface IAccountService
    {
        IEnumerable<Account> Get();
        Account Get(int id);
        Account Create(Account account);
        Account Update(Account account);
        void Remove(int id);
    }
}
