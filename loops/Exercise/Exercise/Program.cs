using System;

namespace Exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Run();
            
        }
        public static void ForLoop()
        {
            // TODO
            for (int i = -3; i <= 3; i++)
                Console.WriteLine(i);
        }
        
        public static void WhileLoop()
        {
            // TODO
            int i = 3;
            while (i >= -3)
            {
                Console.WriteLine(i);
                i--;
            }
                
        }
        
        public static void Run()
        {
            WhileLoop();
            ForLoop();
            
        }
    }
}