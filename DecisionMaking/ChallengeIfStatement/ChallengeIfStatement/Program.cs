using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace ChallengeIfStatement
{
    internal class Program
    {
        private static string _userName = "";
        private static string _password = "";
        
        public static void Main(string[] args)
        {
            
        Console.WriteLine("Please register a user namer:");
        _userName = Console.ReadLine();
        
        Console.WriteLine("Please enter a password: ");
        _password = Console.ReadLine();

        LogIn(_userName, _password);

        Console.Read();

        }

        public static void LogIn(string usr, string pwd)
        {
            Console.WriteLine("--------- Please Login --------");
            Console.WriteLine();
            Console.Write("user name: ");
            string user = Console.ReadLine();
            Console.Write("password: ");
            String password = Console.ReadLine();

            if (IsRegistered(user, password))
            {
                Console.WriteLine($"Thank you {user} you are registered!");
            }
            else
            {
                Console.WriteLine($"Sorry {user} is not a registered user name or using incorrect password.");}
        }

        public static bool IsRegistered(string usr, string pwd)
        {
            if (usr.Equals(_userName) && pwd.Equals(_password))
            {
                return true;
            }
            return false;
        }
    }
}