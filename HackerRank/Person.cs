using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Person
    {
        int age;

        public Person(int initialAge)
        {
            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void yearPasses()
        {
            age++;
        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }
    }
}
