using System;

namespace ClassBasics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // instance of human
            // create an object of my class
            Human denis = new Human();
            // access public variable from outside
            // denis.firstName = "Denis";
            // denis.lastName = "Menace";
            // call methods of the class
            denis.IntroduceMyself();

            Human michael = new Human();
            michael.IntroduceMyself();
            
            // use of constructor
            Human sissy = new Human("Sissy", "Wagner", "green", 34);
            sissy.IntroduceMyself();
            
            Human chad = new Human("Chad", "Bing", "blue", 38);
            chad.IntroduceMyself();
            
            Console.ReadKey();
            

        }
    }
}