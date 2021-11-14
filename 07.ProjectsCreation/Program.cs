using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int projectime = 3;
            int time = projectime * projects;
            Console.WriteLine($"The architect {name} will need {time} hours to complete {projects} project/s.");
        }
    }
}
