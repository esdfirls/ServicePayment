using System;
using System.Collections.Generic;
using System.Text;
using ServicePayment.Entities;

namespace ServicePayment.Services
{
    class ContractService
    {
        private IOnlineService _onlineService;

        public ContractService(IOnlineService onlineService)
        {
            _onlineService = onlineService;
        }


        public void ProcessPayment(Contract contract, int months)
        {
            
            var payment = contract.Installment.Amount;

            payment = _onlineService.InterestFee(payment, months);
            payment = _onlineService.PaymentTax(payment);

            contract.Installment.Amount = payment;
        }
    }
}