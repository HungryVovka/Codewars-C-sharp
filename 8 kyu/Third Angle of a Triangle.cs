// -----------------------------------------------------------
// You are given two interior angles (in degrees) of a triangle.
// 
// Write a function to return the 3rd.
// 
// Note: only positive integers will be tested.
// 
// https://en.wikipedia.org/wiki/Triangle
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static int OtherAngle(int a, int b)
	{
		return 180 - (a + b);
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