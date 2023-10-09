// -----------------------------------------------------------
// This series of katas will introduce you to basics of doing geometry with computers.
// 
// Write the function circleArea/CircleArea which takes in a Circle object and calculates the area of that circle.
// The Circle class can be seen below:
// 
// public class Circle
// {
// 	public Point Center { get; private set; }
// 	public double Radius { get; private set; }
// 	
// 	public Circle(Point center, double radius)
// 	{
// 		this.Center = center;
// 		this.Radius = radius;
// 	}
// }
// 
// And the Point class can be seen below:
// 
// public class Point
// {
// 	public double X { get; private set; }
// 	public double Y { get; private set; }
// 	
// 	public Point(double x, double y)
// 	{
// 		this.X = x;
// 		this.Y = y;
// 	}
// }
// 
// Documentation:
// Kata.CircleArea Method (Circle)
// Returns the area of a circle.
// 
// Syntax
// 
// public static double CircleArea(
// Circle circle
// 	)
// 
// Parameters
// circle
// Type: Circle
// The circle to calculate the area of.
// 
// Return Value
// Type: System.Double
// A double representing the area of the circle.
// 
// Tests round answers to 6 decimal places.
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static double CircleArea(Circle circle)
	{
		return Math.PI * Math.Pow(circle.Radius, 2);
	}
}

// -----------------------------------------------------------
// License
// Tasks are the property of Codewars (https://www.codewars.com/) 
// and users of this resource.
// 
// All solution code in this repository 
// is the personal property of Vladimir Rukavishnikov
// (vladimirrukavishnikovmail@gmail.com).
// 
// Copyright (C) 2023 Vladimir Rukavishnikov
// 
// This file is part of the HungryVovka/Codewars-C-sharp
// (https://github.com/HungryVovka/Codewars-C-sharp)
// 
// License is GNU General Public License v3.0
// (https://github.com/HungryVovka/Codewars-C-sharp/blob/main/LICENSE)
// 
// You should have received a copy of the GNU General Public License v3.0
// along with this code. If not, see http://www.gnu.org/licenses/
// -----------------------------------------------------------