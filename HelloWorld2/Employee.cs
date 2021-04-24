using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee(string firstName, string lastName, int Salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = Salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} is working.");
        }

        public void Pause()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} has stopped working.");
        }
    }
}
