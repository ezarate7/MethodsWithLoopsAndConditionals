using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void Numbers1000toNeg1000()

        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void CheckIfEqual(int num1, int num2)
        {   if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is NOT equal to {num2}");
            }



        }
        // write a Method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Please enter a number. we will check if its even or odd");
            var userInput = int.Parse(Console.ReadLine());
            if(userInput == 0)
        }

        public static void IsPositiveOrNegative(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("this number is 0");

            }
            if (num < 0)
            {
                Console.WriteLine($"{num} is positive");
            
            }
            else
            {
                Console.WriteLine($"{num} is a negative");

            }
            

        }

        public static void VotingAge()
        {
            Console.WriteLine("Age Verification");
            Console.WriteLine("What is your age");
            var input = int.Parse(Console.ReadLine());
            if (input >= 18)
            {
                Console.WriteLine("Hey! you can vote!");
            }
            else
            {
                Console.WriteLine("Hey! you can't vote!");
            }



        }

    }


}

