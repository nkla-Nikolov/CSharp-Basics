using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();


            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b} - " + ((a + b) % 2 == 0 ? "even" : "odd"));
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b} - " + ((a - b) % 2 == 0 ? "even" : "odd"));
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b} - " + ((a * b) % 2 == 0 ? "even" : "odd"));
                    break;
                case "/":
                    if (b == 0)
                        Console.WriteLine($"Cannot divide {a} by zero");
                    else
                        Console.WriteLine($"{a} / {b} = {(double)a / b:F2}");
                    break;
                case "%":
                    if (b == 0)
                        Console.WriteLine($"Cannot divide {a} by zero");
                    else
                        Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
            }
        }
    }
}
