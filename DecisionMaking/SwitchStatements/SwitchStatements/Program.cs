using System;
using System.Diagnostics.Eventing.Reader;

namespace SwitchStatements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Can't get into the club!");
                    break;
                case 25 :
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            Console.Read();
        }
    }
}