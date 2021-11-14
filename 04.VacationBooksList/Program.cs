using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            double canReadPagesPerHour = double.Parse(Console.ReadLine());
            int daysToReadBook = int.Parse(Console.ReadLine());
            double hoursMustRead = ((bookPages/canReadPagesPerHour)/daysToReadBook);
            Console.WriteLine(hoursMustRead);
        }
    }
}
