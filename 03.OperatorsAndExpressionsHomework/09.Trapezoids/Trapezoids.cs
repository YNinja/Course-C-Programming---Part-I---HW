/* Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.

Examples:
a 	    b 	    h 	    area
5 	    7 	    12  	72
2 	    1 	    33  	49.5
8.5 	4.3 	2.7 	17.28
100 	200 	300 	45000
0.222 	0.333 	0.555 	0.1540125

 */

using System;
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.Write("The lenght of side a is: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("The lenght of side b is: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("The hight is: ");
            double h = Double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is " + ((a + b) / 2) * h);
        }
    }