// -----------------------------------------------------------
// Input: Array of elements
// 
// ["h","o","l","a"]
// 
// Output: String with comma delimited elements of the array in th same order.
// 
// "h,o,l,a"
// 
// Note: if this seems too simple for you try the next level
// 
// Note2: the input data can be: boolean array, array of objects, array of string arrays, array of number arrays... 😕
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
	public static string PrintArray(object[] array)
	{
		return string.Join(
			",", array
			.Select(i => i is object[] ? PrintArray(i as object[]) : i));
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