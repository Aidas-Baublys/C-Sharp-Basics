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
            CalcCollectionSum(GetCollection(2));

            Console.ReadKey();
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else
            {
                return numbersQueue;
            }
        }

        static void CalcCollectionSum(IEnumerable<int> collection)
        {
            int sum = 0;

            foreach (int number in collection)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
