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
            MakeSentence("Kurwa", "blet", "nx");

            Console.WriteLine(GetMinVal(14, 3, 55, -20, 4003, 13, 0));

            int[] min =
            {
                1, 23, 5, 16
            };

            Console.WriteLine(GetMinVal(min));

            Console.ReadKey();
        }

        public static void MakeSentence(params string[] words)
        {
            string sentence = "";

            foreach (string word in words)
            {
                sentence += word + " ";
            }

            Console.WriteLine(sentence);
        }

        public static int GetMinVal(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                min = number < min ? number : min;
            }

            return min;
        }
    }
}
