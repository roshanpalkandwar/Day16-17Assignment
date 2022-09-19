﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Assignment
{
    internal class BinarySearch
    {
        public static void binarysearch()
        {
            string[] cars = { "BMW", "Mercedes", "Jaguar", "Audi", "Lamborgini", "RangeRover", "Discovery" };//initialize Array

            Array.Sort(cars); //sorting Array

            Console.WriteLine("Please enter the car you want to search for:");

            string searchCars = Console.ReadLine();

            int i = Array.BinarySearch(cars, searchCars);

            if (i >= 0)
                Console.WriteLine("Car found at position " + i + "\n");
            else
                Console.WriteLine("Car not found\n");

            Console.WriteLine("press any key to close\n");

            Console.ReadKey();
        }
    }
}
