using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"The {this.Color} car has {this.HP} HP.");
        }

        public virtual void Repair()
        {
            Console.WriteLine($"The {this.Color} car was repaired.");
        }
    }
}
