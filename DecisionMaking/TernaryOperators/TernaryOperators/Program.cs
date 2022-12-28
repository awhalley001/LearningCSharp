using System;

namespace TernaryOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }

            else
            {
                stateOfMatter = "liquid";
            }
             Console.WriteLine($"State of matter is {stateOfMatter}");

             temperature = 32;
             
             // in short
             stateOfMatter = temperature < 0 ? "solid" : "liquid";
             
             Console.WriteLine($"State of matter is {stateOfMatter}");

             temperature = 150;
             
             stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
             
             Console.WriteLine($"State of matter is {stateOfMatter}");
             
              
             Console.Read();
        }
    }
}