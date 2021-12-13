using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            double premierePrice = 12;
            double normalPrice = 7.50;
            double discount = 5;

            double income = 0;

            string typeOfProject = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            switch (typeOfProject)
            {
                case "Premiere":
                    income = rows * columns * premierePrice;
                    break;
                case "Normal":
                    income = rows * columns * normalPrice;
                    break;
                case "Discount":
                    income = rows * columns * discount;
                    break;


            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
