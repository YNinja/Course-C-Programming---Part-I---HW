﻿/* Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.

Examples:
a 	    b 	    c 	    biggest
5 	    2 	    2 	    5
-2 	    -2 	    1 	    1
-2  	4 	    3 	    4
0 	    -2.5 	5 	    5
-0.1 	-0.5 	-1.1 	-0.1

 */

using System;
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
        }
    }