﻿using System;

namespace in2cm
{
    class Program
    {
        static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());
            var cm = inch * 2.54;
            Console.WriteLine(cm);
        }
    }
}
