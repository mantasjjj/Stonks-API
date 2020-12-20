using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public class FinancialGoalServices : IFinancialGoalServices
    {
        private readonly Dictionary<string, FinancialGoal> _financialGoals;

        public FinancialGoalServices()
        {
            _financialGoals = new Dictionary<string, FinancialGoal>();
        }

        public FinancialGoal AddFinancialGoal(FinancialGoal goals)
        {
            _financialGoals.Add(goals.Name, goals);

            return goals;
        }

        public Dictionary<string, FinancialGoal> GetFinancialGoals() 
        {
            return _financialGoals;
        }

        public string RemoveFinancialGoal(string goalName)
        {
            foreach (var g in _financialGoals) {
                if (g.Key == goalName) {
                    _financialGoals.Remove(g.Key);
                    return "Goal: " + goalName + " removed";
                }
            }

            return "No such goal found.";
        }
    }
}
