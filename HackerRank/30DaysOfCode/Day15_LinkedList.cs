using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    static class Day15_LinkedList
    {

        public static void Calculate()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static void CalculateInsertNth()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();                
                head = InsertNth(head, a[0],a[1]);
            }
            display(head);
        }

        public static void CalculateDelete()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                head = InsertNth(head, a[0], a[1]);
            }
            display(head);
            int position = Int32.Parse(Console.ReadLine());

            Delete(head, position);
        }

        public static Node InsertNth(Node head, int data, int position)
        {
            // This is a "method-only" submission. 
            // You only need to complete this method. 
            Node newNode = new Node(data);
            //newNode.data = data;

            if (position == 0 )
            {
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.next = head;
                }

                return newNode;
            }

            Node tempNode = head;

            for (int i = 0; i <= position; i++)
            {

                if (i == position-1)
                {
                    if (tempNode.next == null)
                    {
                        //add to tail
                        tempNode.next = newNode;
                        return head;
                    }
                    else
                    {
                        //insert to the middle
                        newNode.next = tempNode.next;
                        tempNode.next = newNode;
                        return head;
                    }

                    
                }
                else
                {
                    tempNode = tempNode.next;
                    continue;
                }
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static Node insert(Node head, int data)
        {
            // if list has no elements, return a new node
            if (head == null)
            {
                return new Node(data);
            }

            // else iterate through list, add node to tail, and return head
            Node tmp = head;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = new Node(data);

            return head;

            //Node newNode = new Node(data);

            //if (head == null)
            //{
            //    head = newNode;
            //    return head;
            //}
            //else if (head.next == null)
            //{
            //    head.next = newNode;
            //    return head;
            //}
            //else
            //{
            //    insert(head.next, data);
            //}

            //return head;
        }

        public static Node Delete(Node head, int position)
        {
            Node tempNode = head;

            for (int i = 0; i <= position-1; i++)
            {
                if (i == position - 1)
                {
                    if (tempNode.next.next == null)
                    {
                        tempNode.next = null;
                        return head;
                    }
                    else
                    {
                        tempNode.next = tempNode.next.next;
                        return head;
                    }
                }
                
                tempNode = tempNode.next;
            }

            return head;
        }

    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
}
