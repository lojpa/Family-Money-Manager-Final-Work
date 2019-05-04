using FamilyMoneyManagerApp.Context;
using FamilyMoneyManagerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly FamilyMoneyManagerContext _context; 

        public AccountRepository(FamilyMoneyManagerContext context)
        {
            _context = context;
        }

        public Account Create(Account account)
        {
                _context.Add(account);
                _context.SaveChanges();
                return account;
        }

        private bool isValid(Account account)
        {
            if ((account.CurrencyValue == "USD" || account.CurrencyValue == "Euro" || account.CurrencyValue == "BAM") &&
               (account.AccountGroupValue == "Cash" || account.AccountGroupValue == "Asset" ||
               account.AccountGroupValue == "BankAccount" || account.AccountGroupValue == "Credit"))
            {
                return true;
            }
            else
                return false;
        }

        public IEnumerable<Account> Get()
        {
            var accounts = _context.Accounts
               .Include(y => y.ExpenseIncomes)
                   .ThenInclude(c => c.Category)
               .ToList();
            return accounts;
        }

        public Account Get(int id)
        {
            var account = _context.Accounts
                .Include(y => y.ExpenseIncomes)
                    .ThenInclude(c => c.Category)
                .FirstOrDefault(a => a.Id == id);
            if (account == null)
                return null;

            return account;
        }

        public void Remove(int id)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Id == id);
            if(account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
        }

        public Account Update(Account account)
        {
            var acc = _context.Accounts.FirstOrDefault(a => a.Id == account.Id);

            if (acc == null)
                return null;

            _context.Accounts.Update(account);
            _context.SaveChanges();
            return account;
        }
    }
}
