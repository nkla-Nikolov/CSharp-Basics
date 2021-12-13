using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWekk = Console.ReadLine();
            double priceTicket = 0;

            switch (dayOfWekk)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(priceTicket = 12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(priceTicket = 14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(priceTicket = 16);
                    break;
            }
        }
    }
}
