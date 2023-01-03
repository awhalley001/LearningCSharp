using System;

namespace basicloops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // for (int counter = 0; counter <= 20; counter++)
            // {
            //     if(counter % 2 != 0)
            //         Console.WriteLine($"Lap {counter}");
            // }
            int lenghtOfText = 0;
            // int counter = 15;
            //
            string wholeText = "";
            
            do
            {
                // Console.WriteLine(counter);
                // counter++;
                Console.WriteLine("Please enter a name of a friend: ");
                string name = Console.ReadLine();
                int currentLength = name.Length;
                lenghtOfText += currentLength;
                wholeText += name;

            } while (lenghtOfText < 25);
            Console.WriteLine($"Thanks that is enough {wholeText}");
            Console.Read();
        }
    }
}