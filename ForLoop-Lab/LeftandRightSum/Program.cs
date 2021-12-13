using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 0; i < number; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                left += leftNum;
            }

            for (int i = 0; i < number; i++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                right += rightNum;
            }


            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }
        }
    }
}
