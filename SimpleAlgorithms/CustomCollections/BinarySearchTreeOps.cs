using System.Xml;

namespace SimpleAlgorithms.CustomCollections
{
    public class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;
        public int Data;

        public TreeNode(int data)
        {
            this.Data = data;
        }
    }

    public class BinarySearchTreeOps
    {
        public static TreeNode Node = null;

        static BinarySearchTreeOps()
        {
            Node = Insert(Node, 20);
            Node = Insert(Node, 50);
            Node = Insert(Node, 35);
            Node = Insert(Node, 44);
            Node = Insert(Node, 9);
            Node = Insert(Node, 15);
            Node = Insert(Node, 62);
            Node = Insert(Node, 11);
            Node = Insert(Node, 13);
        }

        public static void Init()
        {
            var height = GetHeight(Node);
        }

        public static TreeNode Insert(TreeNode root, int data)
        {
            if (root == null)
                return new TreeNode(data);

            TreeNode node;
            if (data <= root.Data)
            {
                node = Insert(root.Left, data);
                root.Left = node;
            }
            else
            {
                node = Insert(root.Right, data);
                root.Right = node;
            }

            return root;
        }

        /*
        Binary Search Tree (BST):
        The height of a BST is the number of edges between the tree's
         root and its furthest lead.
         */

        public static int GetHeight(TreeNode root)
        {
            return 0;
        }
    }
}