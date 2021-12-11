using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double Meters = double.Parse(Console.ReadLine());

            double PriceForYard = Meters * 7.61;
            double DiscountForYard = PriceForYard * 0.18;
            double FinalSum = PriceForYard - DiscountForYard;
            Console.WriteLine($"The final price is: {FinalSum:f2} lv.");
            Console.WriteLine($"The discount is: {DiscountForYard} lv.");
        }
    }
}
