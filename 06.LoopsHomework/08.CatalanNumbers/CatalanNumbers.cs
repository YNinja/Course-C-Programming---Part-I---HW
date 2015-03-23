/* Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845

 */

using System;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Write an integer between 1 and 100: ");
        decimal n = Decimal.Parse(Console.ReadLine());
        decimal catalan = 1;

        for (int i = 2; i <= n; i++)
        {
            catalan *= (n + i) / i;
        }

        Console.WriteLine(Decimal.Round(catalan, 0));
    }
}