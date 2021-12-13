using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double rosePrice = 5;
            double daliaPrice = 3.80;
            double lalePrice = 2.80;
            double narcisPrice = 3;
            double gladiolaPrice = 2.50;

            double finalPrice = 0;

            string flowerType = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            switch (flowerType)
            {
                case "Roses":
                    if (flowerNumber > 80)
                    {
                        finalPrice -= flowerNumber * rosePrice * 0.10;
                    }
                    finalPrice += flowerNumber * rosePrice;
                    break;
                case "Dahlias":
                    if (flowerNumber > 90)
                    {
                        finalPrice -= flowerNumber * daliaPrice * 0.15;
                    }
                    finalPrice += flowerNumber * daliaPrice;
                    break;
                case "Tulips":
                    if (flowerNumber > 80)
                    {
                        finalPrice -= flowerNumber * lalePrice * 0.15;
                    }
                    finalPrice += flowerNumber * lalePrice;
                    break;
                case "Narcissus":
                    if (flowerNumber < 120)
                    {
                        finalPrice += flowerNumber * narcisPrice * 0.15;
                    }
                    finalPrice += flowerNumber * narcisPrice;
                    break;
                case "Gladiolus":
                    if (flowerNumber < 80)
                    {
                        finalPrice += flowerNumber * gladiolaPrice * 0.20;
                    }
                    finalPrice += flowerNumber * gladiolaPrice;
                    break;
            }

            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeed:f2} leva more.");
            }
        }
    }
}
