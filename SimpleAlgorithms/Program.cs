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
                Console.WriteLine("\n m : Menu \n q : Quit \n l : Lists \n k : Linked Lists \n a : Arrays \n s : Sort an Array");
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
                    case "a":
                        arrayClass.Reverse();
                        break;
                    case "s":
                        //arrayClass.SortNumbers();
                        Console.WriteLine("Give me some integers. Seperated by spaces");
                        var response = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                        arrayClass.SortNumbers(response);
                        break;
                    default:
                        Console.WriteLine("Sorry, I don't recognize that command");
                        break;
                }
            }
        }
    }
}
