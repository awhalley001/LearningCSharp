using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.DarkYellow;
            int num1;
            num1 = 13;

            int num2 = 23;
            int sum = num1 + num2;
            
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f2 / f1;
            
            // learn how to cast
            Console.WriteLine(fDiv);

            string myName = "Adam";
            
            Console.WriteLine("My name is " + myName.ToUpper());
            
            // get user input 
            Console.Write("What is your favorite color? ");
            string readInput = Console.ReadLine();
            
            Console.WriteLine("Your Favorite Color is " + readInput);

            double myDouble = 13.37;
            int myInt;
            
            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            
            // implicit conversion
            int num = 123490303;
            long bigNum = num;
            
            // cast double to int
            myInt = (int)myDouble;
            
            // typeConversion
            string myString = myDouble.ToString();
            
            Console.WriteLine(myInt);
            Console.WriteLine(bigNum);
            Console.WriteLine(myNewDouble);
            Console.WriteLine(myString);
            
            // parse string to integer
            string myFirstString = "15";
            string mySecondString = "13";
            int num10 = Int32.Parse(myFirstString);
            int num20 = Int32.Parse(mySecondString);
            int resultInt = num10 + num20;
            string result = myFirstString + mySecondString;
            
            Console.WriteLine(resultInt);
            Console.WriteLine(result);
            
            string stringForFloat = "0.85"; // datatype should be float   s
            string stringForInt = "12345"; // datatype should be int

            float numFloat = float.Parse(stringForFloat);
            int numInt = Int32.Parse(stringForInt);
            float resultFloat = numFloat + numInt;


            Console.WriteLine(resultFloat);
            Console.WriteLine("The float is {0} and the int is {1} and the string is {2} and {3}"
                , numFloat, numInt, stringForFloat, stringForInt);
            Console.WriteLine($"The float is {numFloat} and the int is {numInt} and the " +
                              $"string is {stringForFloat} and {stringForInt}");

            Console.Read();

        }
    }
}