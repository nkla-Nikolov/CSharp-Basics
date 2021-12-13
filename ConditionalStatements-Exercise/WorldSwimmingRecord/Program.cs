using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double WR = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());

            double distanceInSeconds = distance * timeSec;
            double delay = Math.Floor(distance / 15) * 12.5;

            double finalTime = distanceInSeconds + delay;

            if (finalTime < WR)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }

            else
            {
                double neededTime = finalTime - WR;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");

            }
        }
    }
}
