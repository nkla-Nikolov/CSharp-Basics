using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfDogs = double.Parse(Console.ReadLine());
            double numberOfOtherAnimals = double.Parse(Console.ReadLine());

            const double dogFood = 2.50;
            const double animalFood = 4;

            double expenses = numberOfDogs * dogFood;
            double expensesForOhers = numberOfOtherAnimals * animalFood;
            double sum = expenses + expensesForOhers;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
