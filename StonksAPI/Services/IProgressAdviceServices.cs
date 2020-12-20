using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public interface IProgressAdviceServices
    {
        Dictionary<string, double> GetAdvice(double income);
        double GetPotencialScore(double income);
        Dictionary<string, double> RecommendedValues(double usedForExpenses);
    }
}
