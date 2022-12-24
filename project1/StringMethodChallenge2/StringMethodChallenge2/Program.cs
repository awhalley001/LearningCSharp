using System;

namespace StringMethodChallenge2
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            string usrInput;
            char usrChar;
            string firstName;
            string lastName;
            string fullName;
            
            Console.Write("Enter String Here: ");
            usrInput = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            usrChar = Console.ReadLine()[0];
            Console.WriteLine(usrInput.IndexOf(usrChar));
            
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();

            fullName = $"{firstName} {lastName}";
            
            Console.WriteLine(fullName);



        }
    }
}