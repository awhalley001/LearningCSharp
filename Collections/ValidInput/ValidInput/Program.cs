using System;

namespace ValidInput
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
           string firstValue =  Console.ReadLine();
           
           Console.WriteLine("Select the Data type to validate the input you have entered.");
           Console.WriteLine("Press 1 for string.");
           Console.WriteLine("Press 2 for Integer.");
           Console.WriteLine("Press 3 for Boolean.");
           int dataTypeChoice = Console.Read();

           switch (dataTypeChoice)
           {
               case 1:
                   
                   break;
               case 2:
                   break;
               case 3:
                   break;
           }



        }
    }
}