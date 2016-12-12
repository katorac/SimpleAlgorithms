using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Lists
    {
        public List<string> myList;

        public Lists()
        {
            myList = new List<string> { "Breakfast", "Brunch", "Lunch", "Dinner", "Midnight Feast" };
        }

        public void Reverse()
        {
            Console.WriteLine("\n --- A list containing some values --- \n");

            DisplayList(myList);

            Console.WriteLine("\n --- Reversing the above list, manually --- \n");
            var startAt = myList.Count - 1;
            var newList = new List<string>();

            foreach (string item in myList)
            {
                newList.Add(myList[startAt]);
                startAt--;
            }

            myList = newList;

            DisplayList(myList);
        }

        public void DisplayList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
