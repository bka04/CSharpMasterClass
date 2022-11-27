using System;
namespace CSharpMasterClass
{
    public class Employee2
    {

        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee2()
        {
            Name = "";
            FirstName = "";
            Salary = 0;
        }

        public Employee2(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {

        }

        public void Pause()
        {

        }


    }
}

