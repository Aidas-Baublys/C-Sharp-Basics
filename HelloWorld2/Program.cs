using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        public delegate double PerfCalc(double a, double b);
        public delegate string GetText(string name);

        public static double Add(double a, double b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public static double Divide(double a, double b)
        {
            Console.WriteLine(a / b);
            return a / b;
        }

        public static double Sub(double a, double b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }

        static void Main(string[] args)
        {
            PerfCalc add = Add;
            PerfCalc divide = Divide;
            PerfCalc sub = Sub;
            PerfCalc multiCalc = add + divide + sub;
            multiCalc(10, 5);

            PerfCalc a = (x, y) => x + y;

            PerfCalc b = (x, y) => x * y;

            GetText getText = delegate (string name)
            {
                return $"Hi, {name}.";
            };

            GetText text = (string name) => { return $"Nu nx {name}"; };

            GetText t = name => $"Burka {name}";

            Console.WriteLine(t("Kurwa"));
            Console.WriteLine(b(5, 4));

            Console.ReadKey();
        }
    }
}
