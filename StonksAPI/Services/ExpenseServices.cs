using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public class ExpenseServices : IExpenseServices
    {
        private readonly List<Expense> _expenses;

        public ExpenseServices()
        {
            _expenses = new List<Expense>();
        }

        public Expense AddExpense(Expense expense)
        {
            foreach (Expense exp in _expenses) {
                if (exp.Type == expense.Type) {
                    _expenses.Remove(exp);
                    _expenses.Add(expense);
                    return expense;
                }
            }

            _expenses.Add(expense);

            return expense;
        }

        public List<Expense> GetExpenses()
        {
            return _expenses;
        }
    }
}
