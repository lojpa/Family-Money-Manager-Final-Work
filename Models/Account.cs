using FamilyMoneyManagerApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public AccountGroupEnum AccountGroup { get; set; }

        [Required]
        public CurrencyEnum Currency { get; set; }

        [Required]
        public decimal Amount { get; set; }


        public bool ShowOnDashboard { get; set; }

        public List<ExpenseIncome> ExpenseIncomes { get; set; }

        [NotMapped]
        public string AccountGroupValue
        {
            get
            {
                return AccountGroup.ToString();
            }
        }
        [NotMapped]
        public string CurrencyValue
        {
            get
            {
                return Currency.ToString();
            }
        }

    }
}
