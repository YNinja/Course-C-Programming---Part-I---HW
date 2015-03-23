/* Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within 
the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

Examples:
x 	    y 	    inside K & outside of R
1 	    2 	    yes
2.5 	2 	    no
0 	    1 	    no
2.5 	1 	    no
2 	    0 	    no
4 	    0 	    no
2.5 	1.5 	no
2 	    1.5 	yes
1 	    2.5 	yes
-100 	-100 	no

 */

using System;
    class PointInsideOutside
    {
        static void Main(string[] args)
        {
            double radius = 1.5d;
            Console.Write("x of the circle is: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y of the circle is: ");
            double y = Double.Parse(Console.ReadLine());
            bool InsideCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= radius * radius;
            bool InsideRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
            if ((InsideCircle && InsideRectangle) || (!InsideCircle && !InsideRectangle) || (!InsideCircle && InsideRectangle))
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }