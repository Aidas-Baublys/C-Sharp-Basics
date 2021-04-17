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
            // Small program that checks user input type.

            Console.Write("Enter any value, quickly: ");

            string userInput = Console.ReadLine();

            Console.WriteLine("Now select the correct data type of your input:");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            bool selectionCorrect = false;
            string dataType = string.Empty;

            while (!selectionCorrect)
            {
                dataType = Console.ReadLine();

                if (dataType == "1" || dataType == "2" || dataType == "3")
                {
                    selectionCorrect = true;
                }
                else
                {
                    Console.WriteLine("Are you some kind of re-tard?");
                    Console.WriteLine("Select the correct data type of your input:");
                    Console.WriteLine("Press 1 for String");
                    Console.WriteLine("Press 2 for Integer");
                    Console.WriteLine("Press 3 for Boolean");
                }
            }

            string message;

            switch (dataType)
            {
                case "1":
                    message = !userInput.Any(char.IsDigit)
                        ? "Correct. Your input is indeed a string."
                        : "Technically a string, but your input has at least one digit, so no.";
                    break;
                case "2":
                    message = int.TryParse(userInput, out int intValue) ? "Correct. Your input is indeed an integer." : "Nope.";
                    break;
                default:
                    message = bool.TryParse(userInput, out bool boolValue) ? "Correct. Your input is indeed a boolean." : "Nope.";
                    break;
            }

            Console.WriteLine(message);

            Console.Read();
        }
    }
}
