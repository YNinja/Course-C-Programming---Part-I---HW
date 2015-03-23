﻿/* Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has value of 1.

Examples:
n 	    binary representation of n 	p 	bit @ p == 1
5 	    00000000 00000101 	        2 	true
0 	    00000000 00000000 	        9 	false
15 	    00000000 00001111 	        1 	true
5343 	00010100 11011111 	        7 	true
62241 	11110011 00100001 	        11 	false

 */

using System;
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write the value of index p: ");
            int p = Int32.Parse(Console.ReadLine());
            int mask = 1 << p;
            Console.WriteLine((n & mask) == mask);
        }
    }