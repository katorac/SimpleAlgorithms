using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayClass = new Arrays();
            var myList = new Lists();

            var loopState = true;

            while (loopState)
            {
                Console.WriteLine("\n <=====> \n Navigate by pressing any of the following");
                Console.WriteLine("\n m : Menu \n q : Quit \n l : Lists \n k : Linked Lists \n y : Merged linked lists \n a : Arrays \n s : Sort an Array \n e : Return even numbers and their sum \n c : Display duplicates in an array\n u : Anagram words");
                var navigation = new string[] { "l", "m" };
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "m":
                        Console.WriteLine("Main Manu");
                        break;
                    case "q":
                        Console.WriteLine("Have a nice day");
                        loopState = false;
                        break;
                    case "l":
                        myList.Reverse();
                        break;
                    case "k":
                        LinkedLists.Rerverse();
                        break;
                    case "y":
                        var list1 = new LinkedList<int>();
                        list1.AddLast(13);
                        list1.AddLast(2);
                        list1.AddLast(22);

                        var list2 = new LinkedList<int>();
                        list2.AddLast(4);
                        list2.AddLast(3);
                        list2.AddLast(19);
                        list2.AddLast(27);

                        LinkedLists.MergeLinkedLists(list1, list2);
                        break;

                    case "a":
                        arrayClass.Reverse();
                        break;
                    case "s":
                        Console.WriteLine("Give me some integers. Seperated by spaces");
                        var response1 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                        arrayClass.SortNumbers(response1);
                        break;
                    case "e":
                        Console.WriteLine("Give some some integers. Seperated by spaces");
                        var response2 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                        arrayClass.EvenNumbers(response2);
                        break;
                    case "c":
                        Console.WriteLine("Give some some duplicate integers. Seperated by spaces");
                        var response3 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                        arrayClass.MostCommonNumber(response3);
                        break;
                    case "u":
                        Console.WriteLine("Give me two words, seperated by spaces");
                        var reponse4 = Console.ReadLine().Split(' ').ToArray();
                        arrayClass.AnagramReport(reponse4[0], reponse4[1]);
                        break;
                    default:
                        Console.WriteLine("Sorry, I don't recognize that command");
                        break;
                }
            }
        }
    }
}
