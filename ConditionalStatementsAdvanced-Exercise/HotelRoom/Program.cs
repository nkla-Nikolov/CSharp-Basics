using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoneyForStudio = 0;
            double totalMoneyForApartment = 0;

            double mayAndOctoberStudioPrice = 50;
            double mayAndOctoberApartmentPrice = 65;
            double juneAndSeptemberStudioPrice = 75.20;
            double juneAndSeptemberApartmentPrice = 68.70;
            double julyAndAugustStudioPrice = 76;
            double julyAndAugustApartmentPrice = 77;

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                totalMoneyForStudio = nights * mayAndOctoberStudioPrice;
                totalMoneyForApartment = nights * mayAndOctoberApartmentPrice;
                if (nights > 7 && nights < 14)
                {
                    totalMoneyForStudio -= totalMoneyForStudio * 0.05;
                }
                else if (nights > 14)
                {
                    totalMoneyForStudio -= totalMoneyForStudio * 0.30;
                }
            }
            else if (month == "June" || month == "September")
            {
                totalMoneyForStudio = nights * juneAndSeptemberStudioPrice;
                totalMoneyForApartment = nights * juneAndSeptemberApartmentPrice;
                if (nights > 14)
                {
                    totalMoneyForStudio -= totalMoneyForStudio * 0.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                totalMoneyForStudio = nights * julyAndAugustStudioPrice;
                totalMoneyForApartment = nights * julyAndAugustApartmentPrice;
            }

            if (nights > 14)
            {
                totalMoneyForApartment -= totalMoneyForApartment * 0.10;
            }

            Console.WriteLine($"Apartment: {totalMoneyForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
        }
    }
}
