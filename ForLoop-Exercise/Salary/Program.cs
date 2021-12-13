﻿using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTabs; i++)
            {
                string openedTabs = Console.ReadLine();

                if (openedTabs == "Facebook")
                {
                    salary -= 150;
                }
                else if (openedTabs == "Instagram")
                {
                    salary -= 100;
                }
                else if (openedTabs == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
