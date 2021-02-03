using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ServicePayment.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public Installment Installment { get; set; }

        public Contract(int number, DateTime date, double totalValue, Installment installment)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = installment;
        }
        protected Contract()
        {
        }

        public override string ToString()
        {
            return Date.Date.ToString("d")
                   + " - "
                   + TotalValue;
        }
    }
}