/* Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.

Examples:
a 	    b 	    greater
5 	    6 	    6
10 	    5 	    10
0 	    0 	    0
-5 	    -2 	    -2
1.5 	1.6 	1.6

 */

using System;
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The greater number of the two is: {0}", 
                firstNumber > secondNumber ? firstNumber : secondNumber);
        }
    }