using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Voice()
        {
            Console.WriteLine("Wuf.");
        }

        public override void Play()
        {
            if (IsHappy)
                base.Play();
            else
                Console.WriteLine($"{Name} is too sad to play.");
        }
    }
}
