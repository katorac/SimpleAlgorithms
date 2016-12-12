using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Arrays
    {
        public string[] Arr;
        public int[] Numbers;

        public Arrays()
        {
            Arr = new string[] { "Burning Crusade", "WotLK", "Cata", "MoP", "WoD", "Legion" };
            Numbers = new int[] { 15, 22, 6, 65, 4, 2, 19 };
        }

        public void Reverse()
        {
            Console.WriteLine("\n --- An array of expansions --- \n");
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }

            var newArr = new string[Arr.Length];
            var startAt = Arr.Length - 1;

            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = Arr[startAt];
                startAt--;
            }

            Arr = newArr;
            Console.WriteLine("\n --- All the items reversed --- \n");
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
        }

        public void SortNumbers( int[] userNumbers)
        {

            Console.WriteLine("\n --- Sorted numerically: --- \n");
            foreach (var number in userNumbers)
            {
                for (int i = 0; i < userNumbers.Length - 1; i++)
                {
                    var current = userNumbers[i];
                    var next = userNumbers[i + 1];
                    if(current <= next) continue;
                    userNumbers[i] = next;
                    userNumbers[i + 1] = current;
                }
            }

            foreach (var number in userNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
