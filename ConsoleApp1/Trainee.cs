using System;
namespace CSharpMasterClass
{
    public class Trainee : Employee2
    {
        private string WorkingHours { get; set; }
        private string SchoolHours { get; set; }

        public Trainee()
        {
            WorkingHours = "1-5";
            SchoolHours = "8-12";
        }

        public Trainee(string name, string firstName, int salary, string workingHours, string schoolHours) :
            base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning.");
        }

        public override void Work()
        {
            Console.WriteLine($"Trainee working hours: {WorkingHours}");
        }
    }
}

