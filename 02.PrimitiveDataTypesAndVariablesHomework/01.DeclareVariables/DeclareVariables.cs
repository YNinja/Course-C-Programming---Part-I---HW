﻿/* Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types 
    byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
    52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

    Submit the source code of your Visual Studio project as part of your homework submission. */

using System;
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort aNumber = 52130;
            sbyte bNumber = -115;
            uint cNumber = 4825932;
            byte dNumber = 97;
            short eNumber = -10000;
            Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4}", 
                aNumber, bNumber, cNumber, dNumber, eNumber );
        }
    }
