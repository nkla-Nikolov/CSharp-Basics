using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJudges = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double sumOfGrade = 0;
            double sumOfAllGrades = 0;
            int gradeCount = 0;

            while (presentationName != "Finish")
            {

                sumOfGrade = 0;

                for (int i = 1; i <= numOfJudges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfAllGrades += grade;
                    sumOfGrade += grade;
                    gradeCount++;
                }

                double average = sumOfGrade / numOfJudges;
                Console.WriteLine($"{presentationName} - {average:f2}.");

                presentationName = Console.ReadLine();
            }

            double finalAverage = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalAverage:f2}.");
        }
    }
}
