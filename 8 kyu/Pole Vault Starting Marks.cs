// -----------------------------------------------------------
// For a pole vaulter, it is very important to begin the approach run at the best possible starting mark. This is affected by numerous factors and requires 
// fine-tuning in practice. But there is a guideline that will help a beginning vaulter start at approximately the right location for the so-called "three-
// step approach," based on the vaulter's body height.
// 
// This guideline was taught to me in feet and inches, but due to the international nature of Codewars, I am creating this kata to use metric units 
// instead.
// 
// You are given the following two guidelines to begin with: (1) A vaulter with a height of 1.52 meters should start at 9.45 meters on the runway. (2) A 
// vaulter with a height of 1.83 meters should start at 10.67 meters on the runway.
// 
// You will receive a vaulter's height in meters (which will always lie in a range between a minimum of 1.22 meters and a maximum of 2.13 meters). 
// Your job is to return the best starting mark in meters, rounded to two decimal places.
// 
// Hint: Based on the two guidelines given above, you will want to account for the change in starting mark per change in body height. This involves a 
// linear relationship. (If you're not clear on that, search online for "linear equation.") But there is also a constant offset involved. If you can determine 
// the rate of change described above, you should be able to determine that constant offset.
// -----------------------------------------------------------

using System;

class PoleVault
{
	public static double StartingMark(double bodyHeight)
	{
		// Remember: Body height of 1.52 m --> starting mark: 9.45 m
		//           Body height of 1.83 m --> starting mark: 10.67 m
		// All other starting marks are based on these guidelines!
		double a1 = 1.52, b1 = 9.45, a2 = 1.83, b2 = 10.67;
		double x = (b2 - b1) / (a2 - a1);
		double y = (a2 * b1 - a1 * b2) / (a2 - a1);
		double answer = bodyHeight * x + y;
		return Math.Round(answer, 2);
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