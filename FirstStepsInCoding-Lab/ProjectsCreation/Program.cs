﻿using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int NeededTime = projects * 3;


            Console.WriteLine($"The architect {name} will need {NeededTime} hours to complete {projects} project/s.");
        }
    }
}
