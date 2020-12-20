using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public interface IExpenseServices
    {
        Expense AddExpense(Expense expense);
        List<Expense> GetExpenses();
    }
}
