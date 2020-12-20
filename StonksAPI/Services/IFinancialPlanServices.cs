using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public interface IFinancialPlanServices
    {
        FinancialPlan AddFinancialPlan(FinancialPlan plan);
        List<FinancialPlan> GetFinancialPlan();
    }
}
