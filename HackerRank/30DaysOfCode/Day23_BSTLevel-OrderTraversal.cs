using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode.BST
{
    public static class Day23_BSTLevel_OrderTraversal
    {
        public static void Calculate()
        {

            Node root = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    root = Day22_BinarySearchTrees.insert(root, data);
            //}

            root = Day22_BinarySearchTrees.insert(root, 3);
            root = Day22_BinarySearchTrees.insert(root, 5);
            root = Day22_BinarySearchTrees.insert(root, 4);
            root = Day22_BinarySearchTrees.insert(root, 7);
            root = Day22_BinarySearchTrees.insert(root, 2);
            root = Day22_BinarySearchTrees.insert(root, 1);            

            levelOrder(root);
        }

        private static void levelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);            

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                Console.Write(node.data + " ");

                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
          
        }
    }
}
