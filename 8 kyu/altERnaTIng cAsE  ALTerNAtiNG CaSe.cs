// -----------------------------------------------------------
// altERnaTIng cAsE <=> ALTerNAtiNG CaSe
// Define String.prototype.toAlternatingCase (or a similar function/method such as 
// to_alternating_case/toAlternatingCase/ToAlternatingCase in your selected language; see the initial solution for details) such that each 
// lowercase letter becomes uppercase and each uppercase letter becomes lowercase. For example:
// 
// "hello world".ToAlternatingCase() == "HELLO WORLD"
// "HELLO WORLD".ToAlternatingCase() == "hello world"
// "hello WORLD".ToAlternatingCase() == "HELLO world"
// "HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
// "12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
// "1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
// "String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"
// 
// As usual, your function/method should be pure, i.e. it should not mutate the original string.
// -----------------------------------------------------------

namespace Extensions
{
	public static class StringExt
	{
		public static string ToAlternatingCase (this string s)
		{
			char[] letters = s.ToCharArray();
			for (int i = 0; i < letters.Length; i++)
			{
				if (char.IsLower(letters[i]))
				{
					letters[i] = char.ToUpper(letters[i]);
				}
				else if (char.IsUpper(letters[i]))
				{
					letters[i] = char.ToLower(letters[i]);
				}
			}
			return new string(letters);
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