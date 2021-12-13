using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;

            }
            else if (figure == "rectangle")
            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = w * h;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b / 2;
            }

            Console.WriteLine($"{area:f3}");
        }
    }
}
