using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using FamilyMoneyManagerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public Account Create(Account account)
        {
            var createdPost = _repository.Create(account);
            return createdPost;
        }

        public IEnumerable<Account> Get()
        {
            var accounts = _repository.Get();
            return accounts;
        }

        public Account Get(int id)
        {
            var account = _repository.Get(id);
            return account;
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public Account Update(Account account)
        {
            var updatedPost = _repository.Update(account);
            return updatedPost;
        }
    }
}
