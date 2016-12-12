using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class LinkedLists
    {
        public static void Rerverse()
        {
            var linkedList = new LinkedList<string>();

            linkedList.AddFirst("January");
            linkedList.AddLast("December");
            var node = linkedList.Find("January");
            linkedList.AddAfter(node, "February");
            linkedList.AddBefore(linkedList.Find("December"), "November");

            Console.WriteLine(" ---A linked list containg some values  --- \n");

            DisplayLinkedList(linkedList);

            Console.WriteLine("\n --- Reversing the above linked list, manually --- \n");
            //Reversing the above linkedList list

            var copyList = new LinkedList<string>();

            foreach (var item in linkedList)
            {
                copyList.AddFirst(item);
            }

            linkedList = copyList;

            DisplayLinkedList(linkedList);

        }

        public static void DisplayLinkedList(LinkedList<string> linkedList)
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
