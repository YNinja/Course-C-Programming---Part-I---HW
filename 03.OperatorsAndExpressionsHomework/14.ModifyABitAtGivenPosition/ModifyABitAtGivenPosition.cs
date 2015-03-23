/* Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold 
the value v at the position p from the binary representation of n while preserving all other bits in n.

Examples:
n 	    binary representation of n 	p 	v 	binary result 	    result
5 	    00000000 00000101 	        2 	0 	00000000 00000001 	1
0 	    00000000 00000000 	        9 	1 	00000010 00000000 	512
15 	    00000000 00001111 	        1 	1 	00000000 00001111 	15
5343 	00010100 11011111 	        7 	0 	00010100 01011111 	5215
62241 	11110011 00100001 	        11 	0 	11110011 00100001 	62241

 */

using System;
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write the value of index p: ");
            int p = Int32.Parse(Console.ReadLine());
            Console.Write("Write a bit value of 1 or 0: ");
            int v = Int32.Parse(Console.ReadLine());
            int mask = 1 << p;
            bool isOne = (mask & n) == mask;
            if (isOne)
            {
                if (v == 0)
                {
                    Console.WriteLine(n = mask ^ n);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            if (!isOne)
            {
                if (v == 0)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine(n = mask | n);
                }
            }
        }
    }