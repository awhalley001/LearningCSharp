using System;

namespace Properties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);

            Console.WriteLine($"The front surface of the box is {box.FrontSurface} units.");
            
            box.DisplayInfo();
        }
    }
}