/* Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter 
and area formatted with 2 digits after the decimal point.

Examples:
r 	    perimeter 	area
2 	    12.57 	    12.57
3.5 	21.99 	    38.48

 */

using System;
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the circle radius: ");
            double radius = double.Parse(Console.ReadLine());
            double diameter = 2 * radius;

            Console.WriteLine("The circle perimeter is: {0:0.00}", Math.PI * diameter);

            Console.WriteLine("The circle area is: {0:0.00}", Math.PI * Math.Pow(radius, 2));
        }
    }