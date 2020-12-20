using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public class FinancialPlanServices : IFinancialPlanServices
    {
        private readonly List<FinancialPlan> _financialPlans;

        public FinancialPlanServices()
        {
            _financialPlans = new List<FinancialPlan>();
        }

        public FinancialPlan AddFinancialPlan(FinancialPlan plan)
        {
            _financialPlans.Add(plan);

            return plan;
        }

        public List<FinancialPlan> GetFinancialPlan()
        {
            return _financialPlans;
        }
    }
}
