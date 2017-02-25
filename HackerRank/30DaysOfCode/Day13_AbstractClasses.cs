using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day13_AbstractClasses
    {
        public static void Calculate()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }        
    }

    class MyBook : Book
    {
        int price;

        public MyBook(string title, string author, int price):base(title, author)
        {
            this.title = title;
            this.author = author;
            this.price = price;            
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}", this.title);
            Console.WriteLine("Author: {0}", this.author);
            Console.WriteLine("Price: {0}", this.price);
        }
    }


    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }
}
