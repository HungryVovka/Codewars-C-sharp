// -----------------------------------------------------------
// This series of katas will introduce you to basics of doing geometry with computers.
// 
// Point objects have fields X and Y.
// 
// Write a function calculating distance between Point a and Point b.
// 
// Input coordinates fit in range −50 ⩽ x, y ⩽50. Tests compare expected result and actual answer with tolerance of 1e-6.
// -----------------------------------------------------------

using System;

public class Kata
{
	public static double DistanceBetweenPoints(Point a, Point b)
	{
		return Math.Sqrt(
			Math.Pow(a.X - b.X, 2) + 
			Math.Pow(a.Y - b.Y, 2));
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