/* Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.

Examples:
a 	    b 	    c 	    result
5 	    1 	    2 	    5 2 1
-2  	-2 	    1 	    1 -2 -2
-2 	    4 	    3 	    4 3 -2
0 	    -2.5 	5 	    5 0 -2.5
-1.1 	-0.5 	-0.1 	-0.1 -0.5 -1.1
10  	20 	    30 	    30 20 10
1 	    1 	    1 	    1 1 1

 */

using System;
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double first = 0;
            double second = 0;
            double third = 0;
            if (a >= b)
            {
                if (a >= c)
                {
                    first = a;
                    if (b >= c)
                    {
                        second = b;
                        third = c;
                    }
                    else
                    {
                        second = c;
                        third = b;
                    }
                }
                else
                {
                    first = c;
                    second = a;
                    third = b;
                }
            }
            else
            {
                if (b >= c)
                {
                    first = b;
                    if (a >= c)
                    {
                        second = a;
                        third = c;
                    }
                    else
                    {
                        second = c;
                        third = a;
                    }
                }
                else
                {
                    first = c;
                    second = b;
                    third = a;
                }
            }
            Console.WriteLine(first + " " + second + " " + third);
        }
    }