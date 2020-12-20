using System;

namespace StonksAPI
{
    [Serializable]
    public class FinancialGoal
    {
        public double Value { get; set; }
        public String Name { get; set; }
        public DateTime Deadline { get; set; }

        public FinancialGoal() { }
        public FinancialGoal(double value, String name)
        {
            Value = value;
            Name = name;
        }

        public TimeSpan GetTimeToDeadline()
        {
            return Deadline.Subtract(DateTime.Now);
        }

        public void SetDeadlineInTimeSpan(TimeSpan dealineIn)
        {
            Deadline = DateTime.Now.Add(dealineIn);
        }
    }
}
