// -----------------------------------------------------------
// Your task is to sum the differences between consecutive pairs in the array in descending order.
// 
// Example
// [2, 1, 10]  -->  9
// 
// In descending order: [10, 2, 1]
// 
// Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9
// 
// If the array is empty or the array has only one element the result should be 0 (Nothing in Haskell, None in Rust).
// -----------------------------------------------------------

using System;
using System.Linq;

public static class Kata
{
	public static int SumOfDifferences(int[] arr)
	{
		Array.Sort(arr);
		if (arr.Length > 1)
		{
			return Math.Abs(arr[arr.Length - 1] - arr[0]);
		}
		else
		{
			return 0;
		}
	}
}

// or

using System.Linq;

public static class Kata
{
	public static int SumOfDifferences(int[] arr)
	{ 
		return arr.Length > 1 ? arr.Max() - arr.Min() : 0;
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