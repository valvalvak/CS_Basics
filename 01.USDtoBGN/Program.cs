using System;

namespace _01.USDtoBGN
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double USD2BGN= 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double change = usd * USD2BGN;
            Console.WriteLine(change);

        }
    }
}
