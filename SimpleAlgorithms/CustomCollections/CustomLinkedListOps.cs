namespace SimpleAlgorithms.CustomCollections
{
    internal class Node
    {
        internal object Data;
        internal Node Next;

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class XLinkedList
    {
        internal Node Head;

        internal Node Insert(XLinkedList xLinkedList, object data)
        {
            Node newNode = new Node(data);
            newNode.Next = xLinkedList.Head;

            xLinkedList.Head = newNode;

            return newNode;
        }

        internal void InsertLast(XLinkedList xLinkedList, object data)
        {
            Node lastNode = GetLastNode(xLinkedList);
            Node newNode = new Node(data);

            lastNode.Next = newNode;
        }

        internal void InsertAfter(Node prevNode, object data)
        {
            Node newNode = new Node(data);

            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        internal Node GetLastNode(XLinkedList xLinkedList)
        {
            // Always start at the Head
            Node node = xLinkedList.Head;
            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }

        internal void ReverseLinkedListIteratively(XLinkedList xLinkedList)
        {
            Node head = xLinkedList.Head;
            Node node = null;

            while (head != null)
            {
                Node nextNode = head.Next;

                head.Next = node;
                node = head;
                head = nextNode;
            }

            xLinkedList.Head = node;
        }
    }

    internal class CustomLinkedListOps
    {
        internal void Test()
        {
            var xll = new XLinkedList();

            Node node1 = xll.Insert(xll, 17);
            Node node2 = xll.Insert(xll, 12);
            Node node3 = xll.Insert(xll, 6);

            xll.InsertLast(xll, 18);

            xll.InsertAfter(node2, 13);

            Node lastNode = xll.GetLastNode(xll);

            xll.ReverseLinkedListIteratively(xll);
        }
    }

}