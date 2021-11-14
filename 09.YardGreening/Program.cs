using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());
            double price = 7.61 * yards;
            double discount = price * 0.18;
            Console.WriteLine($"The final price is: {price - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
