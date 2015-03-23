/* Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float 
and which to a variable of type double: 
34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them 
to ensure no precision is lost. */

using System;
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double aNumber = 34.567839023;
            float bNumber = 12.345f;
            double cNumber = 8923.1234857;
            float dNumber = 3456.091f;
            Console.WriteLine("No precision lost: \n {0} \n {1} \n {2} \n {3}",
                aNumber, bNumber, cNumber, dNumber);

        }
    }