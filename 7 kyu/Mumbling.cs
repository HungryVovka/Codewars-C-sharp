// -----------------------------------------------------------
// This time no story, no theory. The examples below show you how to write function accum:
// 
// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// 
// The parameter of accum is a string which includes only letters from a..z and A..Z.
// -----------------------------------------------------------

using System;
using System.Collections.Generic;

public class Accumul 
{
		public static String Accum(string s) 
	{
		List<string> mumbling = new List<string>();
		for (int i = 0; i < s.Length; i++)
		{
			string mumb = "";
			for (int j = 0; j < i + 1; j++)
			{
				mumb += j == 0 ? char.ToUpper(s[i]) : char.ToLower(s[i]);
			}
			mumbling.Add(mumb);
		}
		return string.Join("-", mumbling);
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