using System;

namespace GreetFriends
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string nate = "Nathan";
            string mark = "Mark";
            string kyle = "Kyle";
            
            GreetFriend(nate);
            GreetFriend(mark);
            GreetFriend(kyle);
            Console.Read();

        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine($"Hello {name}, my friend!");
        }
    }
}