/* Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) 
is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive

Examples:
n 	Prime?
1 	false
2 	true
3 	true
4 	false
9 	false
97 	true
51 	false
-3 	false
0 	false

 */

using System;
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number /<=100/: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPrime);
        }
    }