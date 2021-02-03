using System;
using System.Globalization;
using ServicePayment.Entities;
using ServicePayment.Services;

namespace ServicePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data");
            Console.Write("Number:");
            var number = int.Parse(Console.ReadLine());
            Console.Write("Date:");
            var date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value:");
            var contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments:");
            var installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue, new Installment(date.AddMonths(installments), contractValue/installments));

            ContractService contractService = new ContractService(new PaypalServices());


            Console.WriteLine("Installments: ");
            for (int i = 1; i <= installments; i++)
            {
                contractService.ProcessPayment(contract, i);
                Console.Write(date.AddMonths(i).Date.ToString("d"));
                Console.Write(" - ");
                Console.Write(contract.Installment.Amount.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                contract.Installment.Amount = contractValue / installments;

            }
        }
    }
}