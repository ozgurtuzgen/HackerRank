﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day18_QueuesAndStacks
    {
        public static void Calculate()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }

    class Solution
    {
        Queue<char> queue =new Queue<char>();
        Stack<char> stack = new Stack<char>();

        internal char dequeueCharacter()
        {
            return queue.Dequeue();
        }

        internal void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        internal char popCharacter()
        {
            return stack.Pop();
        }

        internal void pushCharacter(char c)
        {
            stack.Push(c);
        }
    }
}
