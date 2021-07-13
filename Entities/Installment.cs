using System;
using System.Globalization;

namespace Interfaces.Entities
{
    public class Installment
    {
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public Contract Contract {get; set; }

        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}