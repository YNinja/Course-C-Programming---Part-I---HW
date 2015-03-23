/* Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of 
a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

Examples:
a 	    b 	    c 	    roots
2 	    5 	    -3 	    x1=-3; x2=0.5
-1 	    3 	    0 	    x1=3; x2=0
-0.5 	4 	    -8 	    x1=x2=4
5 	    2 	    8 	    no real roots

 */

using System;
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a real number: ");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a real number: ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a real number: ");
            double c = Double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (discriminant == 0)
            {
                Console.WriteLine("x1=x2={0}", (-b / (2 * a)));
            }
            if (discriminant > 0)
            {
                Console.WriteLine("x1={0}; x2={1}", ((-b - Math.Sqrt(discriminant)) / (2 * a)), ((-b + Math.Sqrt(discriminant)) / (2 * a)));
            }
        }
    }