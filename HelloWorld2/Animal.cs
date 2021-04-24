using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        public virtual void Voice() { }

        public virtual void Eat()
        {
            string message = IsHungry ? $"{Name} is eating." : $"{Name} is not hungry.";

            Console.WriteLine(message);
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }
}
