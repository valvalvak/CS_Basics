using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int oherPets = int.Parse(Console.ReadLine());
            double dogsFood = dogs * 2.50;
            double petsFood = oherPets * 4;
            double totalsum = dogsFood + petsFood;
            Console.WriteLine($"{totalsum} lv.");
        }
    }
}
