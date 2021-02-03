using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePayment.Services
{
    interface IOnlineService
    {
        public double InterestFee(double amount, int months);
        public double PaymentTax(double amount);
    }
}