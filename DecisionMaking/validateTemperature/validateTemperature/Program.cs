using System;

namespace validateTemperature
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int temp = 0;
            string statement;
            
            Console.Write("What is the temp outside? ");
            bool isValid = int.TryParse(Console.ReadLine(), out temp);

            if (isValid)
            {
                statement =  temp > 28 ? "it is hot here" : temp > 15 ? " it is ok" :"it is too cold";
                Console.WriteLine($"{statement}");
            }
            else
            {
                Console.WriteLine("A valid number was not entered");
            }
            
            Console.Read();
        }
    }
} 