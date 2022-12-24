using System;

namespace LowerUpperExcercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";
            
            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }

        public static String LowUpper(string phrase)
        {
            string formattedPhrase = phrase.ToLower() + phrase.ToUpper();
            return formattedPhrase;
        }

        public static void Count(string phrase)
        {
            int x = phrase.Length;
            Console.WriteLine($"The amount of characters is {x}.");
        }
    }
}