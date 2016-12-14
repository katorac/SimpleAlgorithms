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
            Console.WriteLine("\n --- All of the items reversed --- \n");
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

        public void EvenNumbers(int[] userNumbers)
        {
            int total = 0;
            foreach (var number in userNumbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                    Console.WriteLine($"Even number: {number}");
                }
            }
            Console.WriteLine($"Total of all even numbers: {total}");
        }

        public void MostCommonNumber(int[] userNumbers)
        {
            var d = new Dictionary<int, int>();
            var biggestKey = 0;
            var biggestValue = 0;

            foreach (var i in userNumbers)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                }
                else
                {
                    d.Add(i,1);
                }
            }

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key} appears {item.Value} times");

                if (item.Value > biggestValue)
                {
                    biggestKey = item.Key;
                    biggestValue = item.Value;
                }
            }

            Console.WriteLine($"{biggestKey} appears the most: {biggestValue} time");

        }

        public void AnagramReport(string word1, string word2)
        {
            var word1Arr = word1.ToLower().ToCharArray();
            var word2Arr = word2.ToLower().ToCharArray();

            Array.Sort(word1Arr);
            Array.Sort(word2Arr);

            var newWord1 = new string(word1Arr);
            var newWord2 = new string(word2Arr);

            if (newWord1 == newWord2)
            {
                Console.WriteLine($"Yes {word1} and {word2} are anagrams");
            }
            else
            {
                Console.WriteLine($"No {word1} and {word2} are NOT anagrams");
            }
        }

    }
}
