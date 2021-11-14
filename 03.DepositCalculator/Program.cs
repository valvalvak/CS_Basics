using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositValue = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double annualTax = double.Parse(Console.ReadLine());
            double sumResult = ((((depositValue * annualTax)/100) / 12) * depositMonths) + depositValue;
            Console.WriteLine(sumResult);
        }
    }
}
