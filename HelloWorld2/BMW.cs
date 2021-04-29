using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class BMW : Car
    {
        private string brand = "Good";
        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public sealed override void Repair()
        {
            Console.WriteLine("Eik nx");
        }
    }
}
