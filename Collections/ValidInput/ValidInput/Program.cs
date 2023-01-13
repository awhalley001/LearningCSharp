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
           string dataTypeChoice = Console.ReadLine();

           int choiceInt = int.Parse(dataTypeChoice);
           
           Console.WriteLine(choiceInt);
           char[] stringArray = firstValue.ToCharArray();

           string dataTypeCorrect = "is a valid";
           int stringInteger;
           switch (choiceInt)
           {
               case 1:
                   foreach(char k in stringArray)
                   {
                       bool a = Char.IsDigit(k);
                       if (a == true)
                       {
                           dataTypeCorrect = "is an invalid";
                           break;
                       }
                   }
                   Console.WriteLine($"{firstValue} {dataTypeCorrect} string");
                   break;
               case 2:
                   foreach(char k in stringArray)
                   {
                       bool a = Char.IsDigit(k);
                       if (a != true)
                       {
                           dataTypeCorrect = "is an invalid";
                           break;
                       }
                   }
                   Console.WriteLine($"{firstValue} {dataTypeCorrect} integer");
                   break;
               case 3:
                   // Console.WriteLine(firstValue);
                   if (firstValue != "true" || firstValue != "false")
                   {
                       dataTypeCorrect = "is an invalid";
                   }
                   Console.WriteLine($"{firstValue} {dataTypeCorrect} boolean");
                   break;
           }



        }
    }
}