// -----------------------------------------------------------
// Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside. 
// The strings will not be the same length, but they may be empty ( zero length ).
// 
// Hint for R users:
// 
// The length of string is not always the same as the number of characters
//
// For example: (Input1, Input2) --> output
// 
// ("1", "22") --> "1221"
// ("22", "1") --> "1221"
// -----------------------------------------------------------

using System.Collections.Generic;

public class ShortLongShort
{
	public static string Solution(string a, string b)
	{
		List<string> arr = new List<string>();
		if (a.Length > b.Length)
		{
			arr.Insert(0, b);
			arr.Add(a);
			arr.Add(b);
		}
		if (a.Length < b.Length)
		{
			arr.Insert(0, a);
			arr.Add(b);
			arr.Add(a);
		}
		return string.Join("", arr.ToArray());
	}
}

// or

public class ShortLongShort
{
	public static string Solution(string a, string b)
	{
		return a.Length > b.Length ? b + a + b : a + b + a;
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