/* Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

Examples:
weight 	weight on the Moon
86   	14.62
74.6 	12.682
53.7 	9.129
 */

using System;
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Too see what your weight on the Moon would be, please enter you Earth weight here: ");
            decimal earthWeight = decimal.Parse(Console.ReadLine());
            decimal moonWeightPart = 0.17M;
            Console.WriteLine("Your approximate weight on the Moon will be: ");
            Console.WriteLine(earthWeight * moonWeightPart);
        }
    }