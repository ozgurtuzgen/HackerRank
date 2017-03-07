using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode.BST
{
    class Day22_BinarySearchTrees
    {
        static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            int left = 1 + getHeight(root.left);
            int right = 1 + getHeight(root.right);

            return Math.Max(left, right);
        }
        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public static void Calculate()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            //root = insert(root, 3);
            //root = insert(root, 5);
            //root = insert(root, 2);
            //root = insert(root, 1);
            //root = insert(root, 4);
            //root = insert(root, 6);
            //root = insert(root, 7);

            int height = getHeight(root);
            Console.WriteLine(height);

        }

    }
    public class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
