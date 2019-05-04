using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Repositories
{
    public interface IAccountRepository
    {
        IEnumerable<Account> Get();
        Account Get(int id);
        Account Create(Account account);
        Account Update(Account account);
        void Remove(int id);
    }
}
