using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            this.Name = "Cube";
            this.Length = length;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This {this.Name} has a volume of {this.Volume()}.");
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
    }
}
