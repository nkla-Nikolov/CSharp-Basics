using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string currentTask = Console.ReadLine();
            string lastTask = "";
            int countOfTasks = 0;
            double amauntOfGrades = 0;
            int badGradeCounter = 0;

            while (currentTask != "Enough")
            {

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradeCounter++;
                }

                if (badGradeCounter == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
                    return;
                }

                amauntOfGrades += grade;

                lastTask = currentTask;
                countOfTasks++;
                currentTask = Console.ReadLine();
            }

            double averageScore = amauntOfGrades / countOfTasks;
            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {countOfTasks}");
            Console.WriteLine($"Last problem: {lastTask}");
        }
    }
}
