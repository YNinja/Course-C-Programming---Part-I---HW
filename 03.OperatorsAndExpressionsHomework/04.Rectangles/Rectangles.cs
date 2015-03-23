/* Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.

Examples:
width 	height 	perimeter 	area
3 	    4   	14  	    12
2.5 	3 	    11  	    7.5
5 	    5 	    20  	    25

 */

using System;
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the rectangle's width: ");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the rectangle's height: ");
            decimal height = decimal.Parse(Console.ReadLine());
            decimal perimeter = 2 * (width + height);
            decimal area = width * height;
            Console.WriteLine("The rectangle's perimeter is: ");
            Console.WriteLine(perimeter);
            Console.WriteLine("The rectangle's area is: ");
            Console.WriteLine(area);
        }
    }