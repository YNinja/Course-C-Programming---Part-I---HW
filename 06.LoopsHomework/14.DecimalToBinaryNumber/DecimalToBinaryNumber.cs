/* Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	    binary
0	        0
3	        11
43691	    1010101010101011
236476736	1110000110000101100101000000

 */

using System;
class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.Write("Write a decimal number: ");
        long input = long.Parse(Console.ReadLine());
        long number = 0;
        string result = "";

        while (input > 0)
        {
            number = input % 2;
            input = input / 2;
            result = number + result;
        }

        Console.WriteLine(result);
    }
}