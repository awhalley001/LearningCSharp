using System;

namespace TryParse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string numberAsString = "128";
            int parsedValue;
            
            bool success = int.TryParse(numberAsString, out parsedValue);
            
            // The returned boolean is true when parsing was successful

            if (success)
            {
                Console.WriteLine($"Parsing successful - number is {parsedValue}");
            }
            else
            {
                Console.WriteLine("Parsing Failed."); 
            }
        }
    }
}