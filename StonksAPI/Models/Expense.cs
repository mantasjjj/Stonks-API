using System;

namespace StonksAPI
{
    public enum ExpenseType
    {
        Groceries,
        Housing,
        Transport,
        Entertainment,
        Health,
        Shopping,
        Utilities,
        Other
    }

    [Serializable]
    public class Expense
    {
        public ExpenseType Type { get; set; }
        public double Value { get; set; }
        public double PlannedValue { get; set; }

        public Expense ()
        {
        }

        public Expense (ExpenseType type, double value, double plannedValue)
        {
            Type = type;
            Value = value;
            PlannedValue = plannedValue;
        }
    }
}
