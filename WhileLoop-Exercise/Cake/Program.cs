using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int takenPieces = 0;
            int cakeSize = width * lenght;

            while (cakeSize > takenPieces)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{cakeSize - takenPieces} pieces are left.");
                    return;
                }

                takenPieces += int.Parse(command);
            }

            Console.WriteLine($"No more cake left! You need {takenPieces - cakeSize} pieces more.");
        }
    }
}
