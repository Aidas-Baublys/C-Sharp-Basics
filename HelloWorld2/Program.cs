using System;
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
            Human basicBitch = new Human();
            basicBitch.SayMyName();

            Human level1Bitch = new Human("Bitchadra");
            level1Bitch.SayMyName();

            Human level2Bitch = new Human("Bitchadra", "Viagrosa");
            level2Bitch.SayMyName();

            Human level3Bitch = new Human("Bitchadra", "Viagrosa", 69);
            level3Bitch.SayMyName();

            Human bitchSupreme = new Human("Bitchadra", "Viagrosa", 69, true);
            bitchSupreme.SayMyName();

            Console.Read();
        }
    }
}
