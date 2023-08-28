// -----------------------------------------------------------
// Given an array of ones and zeroes, convert the equivalent binary value to an integer.
// 
// Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.
// 
// Examples:
// 
// Testing: [0, 0, 0, 1] ==> 1
// Testing: [0, 0, 1, 0] ==> 2
// Testing: [0, 1, 0, 1] ==> 5
// Testing: [1, 0, 0, 1] ==> 9
// Testing: [0, 0, 1, 0] ==> 2
// Testing: [0, 1, 1, 0] ==> 6
// Testing: [1, 1, 1, 1] ==> 15
// Testing: [1, 0, 1, 1] ==> 11
// 
// However, the arrays can have varying lengths, not just limited to 4.
// -----------------------------------------------------------

using System;

namespace Solution
{
	class Kata
	{
		public static int binaryArrayToNumber(int[] BinaryArray)
		{
			int num = 0;
			int i = 1;
			Array.Reverse(BinaryArray);
			for (int j = 0; j < BinaryArray.Length; j++)
			{
				num += i * BinaryArray[j];
				i *= 2;
			}
			return num;
		}
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