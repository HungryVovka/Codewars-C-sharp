// -----------------------------------------------------------
// Create a function that returns the CSV representation of a two-dimensional numeric array.
// 
// Example:
// 
// input:
//    [[ 0, 1, 2, 3, 4 ],
//     [ 10,11,12,13,14 ],
//     [ 20,21,22,23,24 ],
//     [ 30,31,32,33,34 ]] 
//     
// output:
//      '0,1,2,3,4\n'
//     +'10,11,12,13,14\n'
//     +'20,21,22,23,24\n'
//     +'30,31,32,33,34'
// 
// Array's length > 2.
// 
// More details here: https://en.wikipedia.org/wiki/Comma-separated_values
// -----------------------------------------------------------

using System.Text;

public static class Kata
{
	public static string ToCsvText(int[][] array)
	{
		StringBuilder sb = new StringBuilder();
		foreach (int[] arr in array)
		{
			sb.AppendLine(string.Join(",", arr));
		}
		return sb.ToString().TrimEnd();
	}
}

// or

using System.Collections.Generic;

public static class Kata
{
	public static string ToCsvText(int[][] array)
	{
		List<string> newArr = new List<string>();
		foreach (int[] arr in array)
		{
			newArr.Add(string.Join(",", arr));
		}
		return string.Join("\n", newArr);
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