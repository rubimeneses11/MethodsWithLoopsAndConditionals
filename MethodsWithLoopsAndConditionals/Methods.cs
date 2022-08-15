using System;
namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}.");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}.");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.

        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"You can vote!");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, you are too young to vote.");
                return false;
            }
        }

        //Write a method to check if an integer (from the user) is in the range -10 to 10

        public static void IsInRange()
        {
            Console.WriteLine($"Give me a number to check if it is between 10 and -10.");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine($"Your number is within -10 and 10.");
            }
            else
            {
                Console.WriteLine($"Your number is not within -10 and 10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {number * i}.");
            }
        }
    }
}