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
        //Write a method to check whether a given number is positive or negative.
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
        //Write a method to read the age of a candidate and determine whether they
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

        //Write a method to check if an integer(from the user) is in the range -10 to 10.
        public static void NumberRange()
        {
            Console.WriteLine("Enter in a number, and I will tell you if its in range");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine("Number is in range");
            }
            else
            {
                Console.WriteLine("number is not in range"); 
            }
            

            

        }


        public static void MultTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {num * i } ";
            }
        }
    
    
    
    }


}

