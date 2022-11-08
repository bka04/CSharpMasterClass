using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle {
            get { return jobTitle; }
            set { jobTitle = value; } 
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"My name is {memberName}, and my job title is {jobTitle}. I am {age} years old.");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // cleanup statements - when deleted, runs out of scope, etc
            Console.WriteLine("Destruction of Members object");
            Debug.WriteLine("Destruction of Members object");
        }

    }
}
