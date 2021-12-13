using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int count = 0;

            while (currentBook != "No More Books")
            {
                if (currentBook == book)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                count++;
                currentBook = Console.ReadLine();
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");
        }
    }
}
