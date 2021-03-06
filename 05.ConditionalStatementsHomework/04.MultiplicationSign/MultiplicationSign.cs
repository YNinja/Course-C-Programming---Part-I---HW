﻿/* Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.

Examples:
a 	    b 	    c 	    result
5 	    2 	    2 	    +
-2 	    -2 	    1 	    +
-2  	4 	    3 	    -
0 	    -2.5 	4 	    0
-1 	    -0.5 	-5.1 	-

 */

using System;
class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.Write("Write a number: ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Write a number: ");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Write a number: ");
        double c = Double.Parse(Console.ReadLine());
        sbyte count = 0;
        string sign = "";
        if (a < 0)
        {
            count++;
        }
        if (b < 0)
        {
            count++;
        }
        if (c < 0)
        {
            count++;
        }
        if (count % 2 != 0)
        {
            sign = "-";
        }
        else
        {
            sign = "+";
        }
        if (a == 0 || b == 0 || c == 0)
        {
            sign = "0";
        }
        Console.WriteLine(sign);
    }
}