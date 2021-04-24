using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Igor", "Pupa", 1000);
            employee.Work();
            employee.Pause();

            Boss boss = new Boss("Tom", "Bos", "VW", 10000);
            boss.Lead();
            boss.Work();
            boss.Pause();

            Trainee trainee = new Trainee("Suka", "Nx", 50, 2, 6);
            trainee.Learn();
            trainee.Work();
            trainee.Pause();

            Console.ReadKey();
        }
    }
}
