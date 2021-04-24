using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string firstName, string lastName, int Salary, int workingHours, int schoolHours) : base(firstName, lastName, Salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} is learning.");
        }

        public override void Work()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} working hours are {this.WorkingHours}.");
        }
    }
}
