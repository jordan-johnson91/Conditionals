using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");

            int age = int.Parse(Console.ReadLine());

            if(age >= 17)
            {
                Console.WriteLine("You can see this movie");
            }

            else
            {
                Console.WriteLine("Sorry you are too young you need a parent present");
            }
        }
    }
}
