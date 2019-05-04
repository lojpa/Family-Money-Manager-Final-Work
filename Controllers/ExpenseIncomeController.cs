using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/expenseIncomes")]
    [ApiController]
    public class ExpenseIncomeController : Controller
    {
        private readonly IExpenseIncomeService _expenseIncomeService;

        public ExpenseIncomeController(IExpenseIncomeService expenseIncomeService)
        {
            _expenseIncomeService = expenseIncomeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExpenseIncome>> Get()
        {
            var expenseIncomes = _expenseIncomeService.Get();
            return Ok(expenseIncomes);
        }

        [HttpGet("{id}")]
        public ActionResult<ExpenseIncome> Get(int id)
        {
            var expenseIncome = _expenseIncomeService.Get(id);
            if (expenseIncome == null)
                return NotFound();
            return Ok(expenseIncome);
        }

        [HttpPost]
        public ActionResult<ExpenseIncome> Create(ExpenseIncome expenseIncome)
        {
            var createdExpenseIncome = _expenseIncomeService.Create(expenseIncome);
            if (createdExpenseIncome == null)
                return BadRequest("You didn't choose Expense or Income. Please put correct value and try again!");
            return Ok(createdExpenseIncome);
        }

        [HttpPut]
        public ActionResult<ExpenseIncome> Update(ExpenseIncome expenseIncome)
        {
            var updatedExpenseIncome = _expenseIncomeService.Update(expenseIncome);
            return Ok(updatedExpenseIncome);
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            _expenseIncomeService.Remove(id);
            return NoContent();
        }
    }
}
