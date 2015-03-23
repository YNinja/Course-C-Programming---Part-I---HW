/* Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

Examples:
x 	    y 	    inside
0 	    1 	    true
-2 	    0 	    true
-1  	2 	    false
1.5 	-1 	    true
-1.5 	-1.5 	false
100 	-30 	false
0 	    0 	    true
0.2 	-0.8 	true
0.9 	-1.93 	false
1 	    1.655 	true

 */

using System;
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double radius = 2;
            Console.Write("x of the circle is: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y of the circle is: ");
            double y = Double.Parse(Console.ReadLine());
            bool givenPoint = (x * x + y * y) <= radius * radius;
            Console.WriteLine(givenPoint);
        }
    }