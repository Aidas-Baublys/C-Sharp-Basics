using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string firstName, string lastName, string companyCar, int Salary) : base(firstName, lastName, Salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} is leading.");
        }
    }
}
