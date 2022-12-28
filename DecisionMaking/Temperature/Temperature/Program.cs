using System;
using System.Xml;

namespace Temperature
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like? ");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse((temperature, out number));

            if(userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was no number. 0 set as temperature!");
            }
            
            if (numTemp < 10)
            {
                Console.WriteLine("Take the Coat!");
            }
            else if (numTemp == 10)
            {
                Console.WriteLine("Temperature is 10 degrees celsius!");
            }
            else
            {
                Console.WriteLine("Cozy and warm!");
            }

            Console.Read();
        }
    }
}