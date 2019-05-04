using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Services;
using FamilyMoneyManagerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AccountViewModel>> Get()
        {
            var accounts = _accountService.Get();

            List<AccountViewModel> accList = new List<AccountViewModel>();
            foreach (var account  in accounts)
            {
                accList.Add(new AccountViewModel()
                {
                    Id = account.Id,
                    Name = account.Name,
                    AccountGroupValue = account.AccountGroupValue,
                    CurrencyValue = account.CurrencyValue,
                    Amount = account.Amount,
                    ExpenseIncomes = account.ExpenseIncomes
                });
            }

            return Ok(accList);
        }

        [HttpGet("{id}")]
        public ActionResult<Account> Get(int id)
        {
            var accounts = _accountService.Get(id);
            if (accounts == null)
                return NotFound();
            return Ok(accounts);
        }

        [HttpPost]
        public ActionResult<Account> Create(AccountViewModel account)
        {
            Account acc = new Account();
            if (account.AccountGroupValue == "2")
                acc.AccountGroup = Enums.AccountGroupEnum.Asset;
            else if (account.AccountGroupValue == "1")
                acc.AccountGroup = Enums.AccountGroupEnum.Cash;
            else if (account.AccountGroupValue == "4")
                acc.AccountGroup = Enums.AccountGroupEnum.BankAccount;
            else if (account.AccountGroupValue == "3")
                acc.AccountGroup = Enums.AccountGroupEnum.Credit;

            if (account.CurrencyValue == "USD")
                acc.Currency = Enums.CurrencyEnum.USD;
            else if (account.CurrencyValue == "BAM")
                acc.Currency = Enums.CurrencyEnum.BAM;
            else if (account.CurrencyValue == "EUR")
                acc.Currency = Enums.CurrencyEnum.EUR;
            acc.Amount = account.Amount;
            acc.Name = account.Name;

            var createdAccount = _accountService.Create(acc);
            if (createdAccount == null)
                return BadRequest("You didn't provide appropriate value for currency or account type. Please correct, and try again!");
            return Ok(acc);
        }

        [HttpPut]
        public ActionResult<Account> Update(AccountViewModel account)
        {

            Account acc = new Account();

            if (account.AccountGroupValue == "2")
                acc.AccountGroup = Enums.AccountGroupEnum.Asset;
            else if (account.AccountGroupValue == "1")
                acc.AccountGroup = Enums.AccountGroupEnum.Cash;
            else if (account.AccountGroupValue == "4")
                acc.AccountGroup = Enums.AccountGroupEnum.BankAccount;
            else if (account.AccountGroupValue == "3")
                acc.AccountGroup = Enums.AccountGroupEnum.Credit;


            if (account.CurrencyValue == "USD")
                acc.Currency = Enums.CurrencyEnum.USD;
            else if (account.CurrencyValue == "BAM")
                acc.Currency = Enums.CurrencyEnum.BAM;
            else if (account.CurrencyValue == "EUR")
                acc.Currency = Enums.CurrencyEnum.EUR;
            acc.Amount = account.Amount;
            acc.Name = account.Name;
            acc.Id = account.Id;

            var updatedAccount = _accountService.Update(acc);
            return Ok(updatedAccount);
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            _accountService.Remove(id);
            return NoContent();
        }

    }
}
