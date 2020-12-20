using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public interface IFinancialGoalServices
    {
        FinancialGoal AddFinancialGoal(FinancialGoal goal);
        Dictionary<string, FinancialGoal> GetFinancialGoals();
        string RemoveFinancialGoal(string goalName);
    }
}
