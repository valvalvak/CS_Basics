﻿using System;

namespace _11_Exercise_05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent * 0.2;
            double drinks = cake * 0.55;
            double animator = rent / 3;
            double neededSumForBirthdayParty = rent + cake + drinks + animator;
            Console.WriteLine(neededSumForBirthdayParty);

        }
    }
}
