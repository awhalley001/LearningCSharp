using System;

namespace ArrayBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 20;
            grades[2] = 20;
            grades[3] = 20;
            grades[4] = 20;

            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Grates at index {i}: {grades[i]}");
            }

            Console.WriteLine($"There are {grades.Length} grades ");

        }
    }
}
