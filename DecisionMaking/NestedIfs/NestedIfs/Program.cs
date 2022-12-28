using System;

namespace NestedIfs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("What is your user name?: ");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine($"Hi there {userName}");
                    if(userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin!");
                    }
                }
                    
            }

            Console.Read();
        }
    }
}