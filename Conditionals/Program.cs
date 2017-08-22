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
            //    Console.WriteLine("Enter your age");

            //    int age = int.Parse(Console.ReadLine());

            //    if(age == 21)
            //    {
            //        Console.WriteLine("Lets get a drink");
            //    }
            //    else if(age == 18)
            //    {
            //        Console.WriteLine("You are now an Adult");
            //    }
            //    else if(age >= 17)
            //    {
            //        Console.WriteLine("You can see this movie");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are too young you need a parent present");
            //    }


            //Console.WriteLine("Enter your percentage");
            //int grade = int.Parse(Console.ReadLine());
            //if(grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine("You got an A!!");
            //}
            //else if(grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine("You got a B!! not bad");
            //}

            //ask the user for the total bill
            //ask the user for the number of people at dinner
            //Console.WriteLine("Please enter your total bill");
            //double totalBill = double.Parse(Console.ReadLine());

            //Console.WriteLine("How many people were at dinner");
            //int numberOfPeople = int.Parse(Console.ReadLine());


            ////if the total bill is over 50 10% discount
            //double discount = 0.0;
            //if(totalBill > 50.0d)
            //{
            //    discount = 1.10;
            //    totalBill /= discount;   
            //}
            //else
            //{
            //    discount = 1.05;
            //    totalBill = totalBill / discount;
            //}
            ////else the total bill gets a 5% discount 

            ////inform the user of the new total and how much each person pays
            //double perPerson = totalBill / numberOfPeople;
            //Console.WriteLine("Thank you for dining with us! Your new total is " + totalBill +
            //    " Each person will pay " + perPerson);
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine(number+ " is even");
            }
            else
            {
                Console.WriteLine(number + " is odd");
            }
        }
    }
}
