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
