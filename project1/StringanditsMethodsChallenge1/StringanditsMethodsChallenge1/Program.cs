using System;

namespace StringanditsMethodsChallenge1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myName;
            Console.Write("Please enter your name and press enter: ");
            myName = Console.ReadLine();
            
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.Trim());
            Console.WriteLine(myName.Substring(0,3));
            
            Console.Read();
        }
    }
}