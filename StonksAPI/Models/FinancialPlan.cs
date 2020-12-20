using System;
using System.Collections.Generic;
using System.Linq;

namespace StonksAPI
{
    [Serializable]
    public class FinancialPlan
    {
        public double Income { get; set; }
        public double Savings { get; set; }
        public double PlannedSavings { get; set; }
        public List<FinancialGoal> FinancialGoals { get; set; }
        private List<Expense> Expenses { get; set; }

        public FinancialPlan ()
        {
            FinancialGoals = new List<FinancialGoal>();
            Expenses = new List<Expense>();
        }

        public void AddFinancialGoal(FinancialGoal goal)
        {
            FinancialGoals.Add(goal);
        }

        //returns false if item not found
        public bool RemoveFinancialGoal(FinancialGoal goal)
        {
            return FinancialGoals.Remove(goal);
        }

        //adds new or replaces existing expense
        public void AddExpense(Expense expense)
        {
            if (Expenses.Select(x => x.Type == expense.Type).Count() != 0)
                Expenses.RemoveAll(x => x.Type == expense.Type);

            Expenses.Add(expense);
        }

        //returns false if item not found
        public bool RemoveExpense(Expense expense)
        {
            return Expenses.Remove(expense);
        }

        //returns null if item not found
        public Expense GetExpense(ExpenseType type)
        {
            return Expenses.Where(x => x.Type == type).FirstOrDefault();
        }

        public double GetSpendings()
        {
            return Expenses.Sum(x => x.Value);
        }

        public double GetMaxExpense()
        {
            return Expenses.Max(x => x.Value);
        }

        public double GetSavings(bool recalculate = true)
        {
            if (recalculate)
                RefreshSavings();
            return Savings;
        }

        public double GetPlannedSavings() {
            PlannedSavings = Income;

            foreach (Expense expense in Expenses) {
                PlannedSavings -= expense.PlannedValue;
            }

            return PlannedSavings;
        }

        public void RefreshSavings()
        {
            Savings = Income;
            Expenses.Select(x => Savings -= x.Value);
        }
    }
}
