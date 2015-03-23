/* Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

using System;
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? variable1 = null;
            double? variable2 = null;

            Console.WriteLine("This is integer with null value: {0}", variable1);
            Console.WriteLine("This is double with null value: {0}", variable2);

            Console.WriteLine("This is integer with null value + 5: " + (variable1 + 5));
            Console.WriteLine("This is integer with null value + double with null value: " + (variable1 + variable2));
        }
    }