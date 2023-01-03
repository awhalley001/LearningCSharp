using System;

namespace AverageScore
{
    internal class Program
    {
        public static void Main(string[] args)
        {1
            double averageScore = 0;
            double totalScore = 0;
            double numSudents = 0;
            int currentGrade = 0;
            string gradeEntry = "";

            do
            {
                Console.WriteLine("Enter Students grade: ");
                gradeEntry = Console.ReadLine();
                try
                {
                    int.TryParse(gradeEntry, out currentGrade);
                }
                catch
                {
                    Console.WriteLine("Please enter a vaild grade");
                    continue;
                }
                if (currentGrade != -1)
                {

                    while (currentGrade < 0 || currentGrade > 20 )
                    {
                        Console.WriteLine("Enter grade value between 0 and 20: ");
                        gradeEntry = Console.ReadLine();
                        try
                        {
                            int.TryParse(gradeEntry, out currentGrade);
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a vaild grade");
                            continue;
                        }
                    }
                    totalScore += currentGrade;
                    numSudents++;
                }




            } while (currentGrade != -1);

            averageScore = totalScore / numSudents;

            double AverageGrade = (averageScore / 20.0) *100;

            Console.WriteLine($"The average score is {AverageGrade}");
            Console.Read();
        }
    }
}