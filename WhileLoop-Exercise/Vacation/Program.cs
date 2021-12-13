using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int daysSpending = 0;
            double totalMoney = ownedMoney;


            while (daysSpending != 5)
            {

                string command = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                days++;

                if (command == "spend")
                {
                    daysSpending++;

                    if (sum > totalMoney)
                    {
                        totalMoney = 0;
                    }

                    else
                    {
                        totalMoney -= sum;
                    }
                }

                else if (command == "save")
                {
                    totalMoney += sum;
                    daysSpending = 0;
                }

                if (totalMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }

            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{days}");
        }
    }
}
