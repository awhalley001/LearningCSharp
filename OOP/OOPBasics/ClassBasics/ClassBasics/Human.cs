using System;
using System.CodeDom;

namespace ClassBasics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human()
        {
            firstName = "Mike";
            lastName = "Hanger";
            eyeColor = "blue";
            age = 75;
        }
        
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        
        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        // member method
        public void IntroduceMyself()
        {
            if (age <= 1)
            {
                if (age == 1)
                    Console.WriteLine($"Hi, I'm {firstName} {lastName}. I have {eyeColor} eyes and am {age} year old");
                else
                {
                    Console.WriteLine($"Hi, I'm {firstName} {lastName}. I have {eyeColor} eyes.");
                }
            }
            else
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}. I have {eyeColor} eyes and am {age} years old");
            }
            
        }
    }
}