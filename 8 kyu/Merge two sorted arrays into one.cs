// -----------------------------------------------------------
// You are given two sorted arrays that both only contain integers. Your task is to find a way to merge them into a single one, sorted in asc order. 
// Complete the function mergeArrays(arr1, arr2), where arr1 and arr2 are the original sorted arrays.
// 
// You don't need to worry about validation, since arr1 and arr2 must be arrays with 0 or more Integers. If both arr1 and arr2 are empty, then just 
// return an empty array.
// 
// Note: arr1 and arr2 may be sorted in different orders. Also arr1 and arr2 may have same integers. Remove duplicated in the returned result.
// 
// Examples (input -> output)
// * [1, 2, 3, 4, 5], [6, 7, 8, 9, 10] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
// 
// * [1, 3, 5, 7, 9], [10, 8, 6, 4, 2] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
// 
// * [1, 3, 5, 7, 9, 11, 12], [1, 2, 3, 4, 5, 10, 12] -> [1, 2, 3, 4, 5, 7, 9, 10, 11, 12]
// 
// Happy coding!
// -----------------------------------------------------------

using System.Linq;
using System.Collections.Generic;

public class Kata
{
	public static int[] MergeArrays(int[] arr1, int[] arr2)
	{
		List<int> newarr = arr1.Concat(arr2).ToList();
		newarr = newarr.Distinct().ToList();
		newarr.Sort();
		return newarr.ToArray();
	}
}

// or

using System.Linq;

public class Kata
{
	public static int[] MergeArrays(int[] arr1, int[] arr2)
	{
		var newarr = arr1.Concat(arr2).Distinct().OrderBy(i => i);
		return newarr.ToArray();
	}
}

// or

using System.Linq;

public class Kata
{
	public static int[] MergeArrays(int[] arr1, int[] arr2)
	{
		var newarr = arr1.Union(arr2).OrderBy(i => i);
		return newarr.ToArray();
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