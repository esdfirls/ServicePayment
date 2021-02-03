using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePayment.Entities
{
    class Installment : Contract
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }


        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.Date.ToString("d")
                   + " - "
                   + Amount;
        }
    }
}