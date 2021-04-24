using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            this.Name = "Sphere";
            this.Radius = radius;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This {this.Name} has a volume of {this.Volume()}.");
        }

        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(this.Radius, 3);
        }
    }
}
