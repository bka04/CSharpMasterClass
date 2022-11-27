using System;
namespace CSharpMasterClass
{
    public class Boss : Employee2
    {
        private string CompanyCar;

        public Boss()
        {
            CompanyCar = "";
        }

        public Boss(string name, string firstName, int salary, string companyCar) : base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm leading.");
        }
    }
}

