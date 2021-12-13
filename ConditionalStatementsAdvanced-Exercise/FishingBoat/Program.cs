using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countOfFiserman = int.Parse(Console.ReadLine());

            double priceForSummerAndAutumn = 4200;
            double priceForWinter = 2600;
            double priceForSpring = 3000;

            double totalPrice = 0;

            switch (season)
            {
                case "Winter":
                    totalPrice = priceForWinter;
                    break;
                case "Spring":
                    totalPrice = priceForSpring;
                    break;
                case "Summer":
                    totalPrice = priceForSummerAndAutumn;
                    break;
                case "Autumn":
                    totalPrice = priceForSummerAndAutumn;
                    break;
            }

            if (countOfFiserman <= 6)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (countOfFiserman >= 7 && countOfFiserman <= 11)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (countOfFiserman >= 12)
            {
                totalPrice -= totalPrice * 0.25;
            }

            if (countOfFiserman % 2 == 0 && season != "Autumn")
            {
                totalPrice -= totalPrice * 0.05;
            }


            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");

            }
        }
    }
}
