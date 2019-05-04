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
    public class ExpenseIncome
    {
        public int Id { get; set; }

        [Required]
        public ExpenseIncomeEnum ExpenseOrIncome { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string Comment { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public CurrencyEnum Currency { get; set; }

        [NotMapped]
        public string CurrencyValue
        {
            get
            {
                return Currency.ToString();
            }
        }

        public decimal Balance { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        public int TransferToAccountId { get; set; }

        [NotMapped]
        public string ExpenseIncomeValue { get
            {
                return ExpenseOrIncome.ToString();
            }
        }
    }
}
