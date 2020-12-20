using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StonksAPI.Services;

namespace StonksAPI.Controllers
{
    [Route("api/expense")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseServices _services;

        public ExpensesController(IExpenseServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddExpense")]
        public ActionResult<Expense> AddExpense(Expense expense)
        {
            var expenses = _services.AddExpense(expense);

            if (expenses == null)
            {
                return BadRequest();
            }

            return expenses;
        }

        [HttpGet]
        [Route("GetExpenses")]
        public ActionResult<List<Expense>> GetExpenses()
        {
            var expenses = _services.GetExpenses();

            if (expenses.Count == 0)
            {
                return NotFound();
            }

            return expenses;
        }
    }

}
