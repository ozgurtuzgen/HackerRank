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
                head = InsertNth(head, a[0], a[1]);
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
            display(head);
        }
        public static void CalculateReverse()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);

            head = Reverse(head);

            display(head);
        }

        public static void CalculateMerge()
        {
            Node nodea = new Node(1);
            nodea.next = new Node(5);
            nodea.next.next = new Node(8);

            Node nodeb = new Node(4);
            nodeb.next = new Node(7);
            nodeb.next.next = new Node(9);

            MergeLists(nodea, nodeb);
        }

        public static void CalculateGetNode()
        {
            Node nodea = new Node(1);
            nodea.next = new Node(5);
            nodea.next.next = new Node(8);

            GetNode(nodea, 2);
        }

        public static void RemoveDuplicateTest()
        {
            Node nodea = new Node(1);
            nodea.next = new Node(1);
            nodea.next.next = new Node(1);

            RemoveDuplicates(nodea);
        }

        public static Node InsertNth(Node head, int data, int position)
        {
            // This is a "method-only" submission. 
            // You only need to complete this method. 
            Node newNode = new Node(data);
            //newNode.data = data;

            if (position == 0)
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

                if (i == position - 1)
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
            //empty list
            if (head == null)
            {
                return null;
            }

            //delete first node
            if (position == 0)
            {
                if (head.next == null)
                {
                    return null;
                }
                else
                {
                    return head.next;
                }
            }

            Node tempNode = head;
            int index = 0;

            while (tempNode.next != null)
            {
                index++;

                if (position == index)
                {
                    if (tempNode.next.next == null)
                    {
                        tempNode.next = null;
                    }
                    else
                    {
                        tempNode.next = tempNode.next.next;
                    }

                    return head;
                }
                else
                {
                    tempNode = tempNode.next;
                }
            }

            return head;
        }

        public static void ReversePrint(Node head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.data);
                head = head.next;
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public static Node Reverse(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            Node remaining = Reverse(head.next);

            head.next.next = head;

            head.next = null;

            return remaining;
        }

        public static int CompareLists(Node headA, Node headB)
        {
            while(headA != null)
            {
                if (headB == null)
                {
                    return 0;
                }

                if (headA.data != headB.data)
                {
                    return 0;
                }

                headA = headA.next;
                headB = headB.next;
            }

            if (headB != null)
            {
                return 0;
            }

            return 1;
        }

        public static Node MergeLists(Node headA, Node headB)
        {
            
            if (headA == null)
            {
                return headB;
            }

            if (headB == null)
            {
                return headA;
            }

            // Ensure that list A starts with the smaller number
            if (headA.data > headB.data)
            {
                Node tmp = headB;
                headB = headA;
                headA = tmp;
            }

            Node listHead = headA;

            while (headB != null)
            {
                // Advance through nodes in list A until the next node
                // has data bigger than data at current node of list B
                while (headA.next != null &&
                       headB.data > headA.next.data)
                {
                    headA = headA.next;
                }

                // Insert current node in list B into list A
                Node nextB = headB.next;
                headB.next = headA.next;
                headA.next = headB;
                headB = nextB;
            }

            return listHead;
            
        }

        public static int GetNode(Node head, int n)
        {
           while (head != null)
            {
                Node tempNode = head;
                for (int i = 0; i <= n; i++)
                {
                    if (tempNode != null)
                    {
                        tempNode = tempNode.next;
                    }
                    else
                    {
                        throw new Exception("Invalid Input");
                    }
                }

                if (tempNode == null)
                {
                    return head.data;
                }
                else
                {
                    head = head.next;
                }
            }

            return -1;
        }

        public static Node RemoveDuplicates(Node head)
        {
            Node tempNode = head;

            while (tempNode != null && tempNode.next != null)
            {
               
                if (tempNode.data == tempNode.next.data)
                {
                    if (tempNode.next.next != null)
                    {
                        tempNode.next = tempNode.next.next;
                    }
                    else
                    {
                        tempNode.next = null;
                    }
                }
                else
                {
                    tempNode = tempNode.next;
                }
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
