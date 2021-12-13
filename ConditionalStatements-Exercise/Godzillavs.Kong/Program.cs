using System;

namespace Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //ед 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            double budgetForMovie = double.Parse(Console.ReadLine());
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            int numOfStat = int.Parse(Console.ReadLine());
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            double priceForClothes = double.Parse(Console.ReadLine());


            double decorForMovie = budgetForMovie * 0.10;
            double totalPriceForClothes = numOfStat * priceForClothes;

            if (numOfStat > 150)
            {
                double discount = totalPriceForClothes * 0.10;
                totalPriceForClothes = totalPriceForClothes - discount;
            }

            double totalMoney = decorForMovie + totalPriceForClothes;

            if (totalMoney > budgetForMovie)
            {
                double neededMoney = totalMoney - budgetForMovie;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budgetForMovie - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
