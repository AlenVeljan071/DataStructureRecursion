using System;

namespace DataStructureRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("A");
            Node n1 = new Node("B");
            Node n2 = new Node("C");
            Node n3 = new Node("D");
            Node n4 = new Node("E");
            Node n5 = new Node("F");
            Node n6 = new Node("G");
            Node n7 = new Node("I");
            Node n8 = new Node("J");


            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n1.right = n6;
            n2.left = n4;
            n2.right = n5;
            n3.left = n7;
            n7.right = n8;

            BinarySearchTree.PreOrder(root);
        }

        class Node
        {
            public string value;
            public Node left;
            public Node right;
            public Node(string value)
            {
                this.value = value;
            }
        }
        class BinarySearchTree
        {
            public static void PreOrder(Node root)
            {
                Console.WriteLine(root.value);
                if (root.left != null)
                {
                    PreOrder(root.left);
                }
                if (root.right != null)
                {
                    PreOrder(root.right);
                }
            }
        }
    }
}
