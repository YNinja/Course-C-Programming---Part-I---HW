/* Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
Examples:

n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.

 */

using System;
class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Write a positive integer: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Write the minimum value of the range: ");
        int min = Int32.Parse(Console.ReadLine());
        Console.Write("Write the maximum valie of the range: ");
        int max = Int32.Parse(Console.ReadLine());
        int number;
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            number = rnd.Next(min, max + 1);
            Console.Write(number + " ");
        }
    }
}