using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonksAPI.Services
{
    public class ProgressAdviceServices : IProgressAdviceServices
    {

        public Dictionary<string, double> GetAdvice(double income)
        {
            Dictionary<string, double> _advice = new Dictionary<string, double> ();

            double investingAdvice = income * 0.25;
            double expensesAdvice = income * 0.45;
            double savingsAdvice = income * 0.3;

            _advice.Add("Investing", investingAdvice);
            _advice.Add("Expenses", expensesAdvice);
            _advice.Add("Savings", savingsAdvice);

            return _advice;
        }

        public double GetPotencialScore(double income)
        {
            double p = income * 0.25; // Initial amount
            double pmt = income * 0.25; // Additional payments per period (Monthly payment)
            const double r = 7.0 / 100.0; // Annual interest rate
            const int n = 12; // Interest compounds per year
            const int t = 10; // Period in years

            double a = p;
            for (int i = 0; i < n * t; i++)
            {
                a *= 1 + r / n;
                a += pmt;
            }

            a = Math.Round(a, 1);

            return a;
        }

        public Dictionary<string, double> RecommendedValues(double usedForExpenses)
        {
            Dictionary<string, double> _values = new Dictionary<string, double>();

            var housing = Math.Round(usedForExpenses * 0.3, 1); //2
            var groceries = Math.Round(usedForExpenses * 0.3, 1); //1
            var transport = Math.Round(usedForExpenses * 0.1, 1); //4
            var entertainment = Math.Round(usedForExpenses * 0.04, 1); //7
            var shopping = Math.Round(usedForExpenses * 0.06, 1); //6
            var health = Math.Round(usedForExpenses * 0.1, 1); //3
            var utilities = Math.Round(usedForExpenses * 0.06, 1); //5
            var other = Math.Round(usedForExpenses * 0.04, 1); //8

            _values.Add("Housing", housing);
            _values.Add("Groceries", groceries);
            _values.Add("Transport", transport);
            _values.Add("Entertainment", entertainment);
            _values.Add("Shopping", shopping);
            _values.Add("Health", health);
            _values.Add("Utilities", utilities);
            _values.Add("Other", other);

            return _values;
        }
    }
}
