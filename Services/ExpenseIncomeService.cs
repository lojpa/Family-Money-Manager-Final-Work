using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Services
{
    public class ExpenseIncomeService : IExpenseIncomeService
    {
        private readonly IExpenseIncomeRepository _expenseIncomeRepository;

        public ExpenseIncomeService(IExpenseIncomeRepository expenseIncomeRepository)
        {
            _expenseIncomeRepository = expenseIncomeRepository;
        }

        public ExpenseIncome Create(ExpenseIncome expenseIncome)
        {
            var createdExpenseIncome = _expenseIncomeRepository.Create(expenseIncome);
            return createdExpenseIncome;
        }

        public ExpenseIncome Get(int id)
        {
            var expenseIncome = _expenseIncomeRepository.Get(id);
            return expenseIncome;
        }

        public IEnumerable<ExpenseIncome> Get()
        {
            var expenseIncomes = _expenseIncomeRepository.Get();
            return expenseIncomes;
        }

        public void Remove(int id)
        {
            _expenseIncomeRepository.Remove(id);
        }

        public ExpenseIncome Update(ExpenseIncome expenseIncome)
        {
            var updatedIncome = _expenseIncomeRepository.Update(expenseIncome);
            return updatedIncome;
        }
    }
}
