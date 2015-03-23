/* Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.

Examples:
n 	Odd?
3 	true
2 	false
-2 	false
-1 	true
0 	false
 */

using System;
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To see if a positive or a negative number is odd /odd=true/ just enter the number here: ");
            int number = int.Parse(Console.ReadLine());
            bool isOdd = !(number % 2 == 0);
            Console.WriteLine(isOdd);
        }
    }