// -----------------------------------------------------------
// You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first 
// value.
// 
// The returned value must be a string, and have "***" between each of its letters.
// 
// You should not remove or add elements from/to the array.
// -----------------------------------------------------------

using System;

public class Kata
{
	public static string TwoSort(string[] s)
	{
		Array.Sort(s, StringComparer.Ordinal);
		char[] star = s[0].ToCharArray();
		return string.Join("***", star);
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