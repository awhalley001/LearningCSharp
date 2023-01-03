using System;

namespace BreakAndContinue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                // Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("We skip # 3");
                    //Console.WriteLine("At 3 stop!");
                    // break;
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }
    }
}