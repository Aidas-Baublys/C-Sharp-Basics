using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private bool hasEyes;
        private string message;

        // Default constructor
        public Human()
        {
            Console.WriteLine("Hi, I anonymous, I hack now u, revolution, yeah!");
            Console.WriteLine("GMO. Cunt-structor called. Bo-object created. So basic, OMG.");
            Console.WriteLine("You are seeing this, because: " +
                "1) I have a great sense of pun and " +
                "2) The human class did not recieve any data whatsoever");
        }

        // Constructors for limited/incomplete data cases:
        public Human(string name)
        {
            this.name = name;
        }

        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;  
        }

        public Human(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Human(string name, string surname, int age, bool hasEyes)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.hasEyes = hasEyes;
        }

        public void SayMyName()
        {
            if (name != null)
            {
                message = $"Hi, I am {name}, nice to meet you. Not.";

                if (surname != null)
                {
                    message = $"Hi, I am {name} {surname}, nice to meet you, sir/madam.";

                    if (age != 0)
                    {
                        message = $"Hi, I am {name} {surname}, {age} years old, get on with it.";

                        if (hasEyes)
                        {
                            message = $"Hi, I am {name} {surname}, {age} years old, with eyes. Nice to see you.";
                        }
                        else
                        {
                            message = $"Hi, I am {name} {surname}, {age} years old, without eyes. Nice to see you.";
                        }
                    }
                }
            } 

            Console.WriteLine(message);
        }
    }
}
