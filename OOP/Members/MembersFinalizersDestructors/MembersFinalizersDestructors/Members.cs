using System;
using System.Diagnostics;

namespace MembersFinalizersDestructors
{
    public class Members
    {
        // private member
        private string memberName;
        private string jobTitle;

        private int salary = 20000;
        // public member
        public int age;
        
        public string JobTitle { get; set; }
        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            Console.WriteLine($"Hi, name is {memberName}. My job title is {JobTitle}, and I am {age} years old");
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }
        
        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object Created");
        }
        // member - finalizer -destructor
        ~Members()
        {
            //clean up statements
            Console.WriteLine("Deconstruction of Members Object");
            Debug.Write("Deconstruction of Members Object");
        }

    }
}