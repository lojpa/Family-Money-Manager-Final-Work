using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.ViewModels
{
    public class AccountViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public List<ExpenseIncome> ExpenseIncomes { get; set; }

        public string AccountGroupValue
        {
            get; set;
        }
        public string CurrencyValue
        {
            get; set;
        }
    }
}
