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

        public static void MergeLinkedLists(LinkedList<int> l1, LinkedList<int> l2)
        {
            Console.WriteLine("\n --- List 1: ---");
            var list1 = l1.OrderBy(x => x);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n --- List 2: ---");
            var list2 = l2.OrderBy(x => x);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


            var newList = l1.Union(l2).OrderBy(x => x);
            Console.WriteLine("\n --- Merged list: ---");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
