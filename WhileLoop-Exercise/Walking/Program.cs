using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalSteps = 0;

            string command = Console.ReadLine();

            while (goal >= totalSteps)
            {
                if (command == "Going home")
                {
                    int stepsBack = int.Parse(Console.ReadLine());
                    totalSteps += stepsBack;
                    break;
                }

                totalSteps += int.Parse(command);

                command = Console.ReadLine();
            }

            if (totalSteps >= goal)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
