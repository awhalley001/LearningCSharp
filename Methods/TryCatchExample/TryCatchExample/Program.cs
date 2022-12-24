using System;

namespace TryCatchExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("A number is not divisible by zero!");
            }
            
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct data type.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please Enter a number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("General Exception.");
            }
            finally
            {
                // this is run no matter which exception is reached! Good for closing out of database, connection, etc.
                Console.WriteLine("This is called anyways");
            }
            Console.Read();
        }
    }
}