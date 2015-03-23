/* Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n 
and prints all the numbers from 1 to n, on a single line, separated by a space.
Examples:

n	output
3	1 2 3
5	1 2 3 4 5

 */

using System;
class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint firstNumber = 1;
        while (firstNumber <= n)
        {
            Console.Write(firstNumber + " ");
            firstNumber++;
        }
    }
}