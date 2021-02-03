using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePayment.Services
{
    class PaypalServices : IOnlineService
    {
        public double InterestFee(double amount, int months)
        {
            return (amount + amount * 0.01 * months);
        }

        public double PaymentTax(double amount)
        {
            return (amount + amount * 0.02);
        }
    }
}