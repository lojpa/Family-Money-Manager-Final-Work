using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyMoneyManagerApp.Context;
using FamilyMoneyManagerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyMoneyManagerApp.Repositories
{
    public class ExpenseIncomeRepository : IExpenseIncomeRepository
    {
        private readonly FamilyMoneyManagerContext _context;

        public ExpenseIncomeRepository(FamilyMoneyManagerContext context)
        {
            _context = context;
        }

        public ExpenseIncome Create(ExpenseIncome expenseIncome)
        {
            if (expenseIncome.ExpenseOrIncome.ToString() != "Expense" && expenseIncome.ExpenseOrIncome.ToString() != "Income" && expenseIncome.ExpenseOrIncome.ToString() != "Transfer")
                return null;

            expenseIncome.TransferToAccountId = 0;

            _context.Add(expenseIncome);
            _context.SaveChanges();
            return expenseIncome;
        }

        public ExpenseIncome Get(int id)
        {
            var expenseIncome = _context.ExpenseIncomes.Include(ei => ei.Category).Include(ei => ei.Account).FirstOrDefault(ei => ei.Id == id);
            if (expenseIncome == null)
                return null;
            return expenseIncome;
        }

        public IEnumerable<ExpenseIncome> Get()
        {
            var expenseIncomes = _context.ExpenseIncomes.Include(ei => ei.Category).Include(ei => ei.Account).Include(e => e.Account.ExpenseIncomes).ToList();
            return expenseIncomes;
        }

        public void Remove(int id)
        {
            var expenseIncome = _context.ExpenseIncomes.FirstOrDefault(ei => ei.Id == id);
            if (expenseIncome != null)
            {
                _context.ExpenseIncomes.Remove(expenseIncome);
                _context.SaveChanges();
            }
        }

        public ExpenseIncome Update(ExpenseIncome expenseIncome)
        {
            var ei = _context.ExpenseIncomes.FirstOrDefault(e => e.Id == expenseIncome.Id);

            if (ei == null)
                return null;

            _context.ExpenseIncomes.Update(expenseIncome);
            _context.SaveChanges();


            return expenseIncome;
        }
    }
}
