using System;

namespace operators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
            
            // unary operators
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"is it sunny? {!isSunny}");
            
            // increment/decrement Operators
            int num = 0;

            num++;
            
            Console.WriteLine(num);
            Console.WriteLine(--num);
            Console.Read();
            
            // relation operators
            bool isLower;
            isLower = num1 < num2;
            
        }
    }
}