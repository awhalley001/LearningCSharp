using System;
using System.Net.Sockets;

namespace MethodsLearning
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int first = 200;
            int second = 300;

           
            WriteSomething(Add(first, second).ToString());
            WriteSomething(Multiply(first, second).ToString());
            WriteSomething(Divide(first, second).ToString());
            Console.Read();
        }
        
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
  
            return result;
        }

        public static void WriteSomething(string a)
        {
            Console.WriteLine(a);
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }
        
    }
}