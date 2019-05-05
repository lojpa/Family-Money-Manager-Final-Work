﻿using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Interfaces
{
    public interface IExpenseIncomeService
    {
        ExpenseIncome Get(int id);
        double GetExpenseTotalAmountByCategory(int categoryId);
        IEnumerable<ExpenseIncome> Get();
        ExpenseIncome Create(ExpenseIncome expenseIncome);
        ExpenseIncome Update(ExpenseIncome expenseIncome);
        void Remove(int id);
    }
}
