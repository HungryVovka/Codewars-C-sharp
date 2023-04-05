// -----------------------------------------------------------
// In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
// 
// Examples
// Kata.MakeNegative(1);  // return -1
// Kata.MakeNegative(-5); // return -5
// Kata.MakeNegative(0);  // return 0
// 
// Notes
// The number can be negative already, in which case no change is required.
// Zero (0) is not checked for any specific sign. Negative zeros make no mathematical sense.
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static int MakeNegative(int number)
	{
		return number > 0 ? (- number) : number;
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