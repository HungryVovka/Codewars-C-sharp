// -----------------------------------------------------------
// Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.
// 
// invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
// invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
// invert([]) == []
// -----------------------------------------------------------

namespace Solution
{
	public static class ArraysInversion
	{
		public static int[] InvertValues(int[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				input[i] *= -1;
			}
			return input;
		}
	}
}

// or

using System.Linq;

namespace Solution
{
	public static class ArraysInversion
	{
		public static int[] InvertValues(int[] input)
		{
			return input.Select(i => i * (-1)).ToArray();
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