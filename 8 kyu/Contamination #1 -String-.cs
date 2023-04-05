// -----------------------------------------------------------
// An AI has infected a text with a character!!
// 
// This text is now fully mutated to this character.
// 
// If the text or the character are empty, return an empty string.
// There will never be a case when both are empty as nothing is going on!!
// 
// Note: The character is a string of length 1 or an empty string.
// 
// Example
// text before = "abc"
// character   = "z"
// text after  = "zzz"
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static string Contamination(string text, string character)
	{
		return String.Concat(Enumerable.Repeat(character, text.Length));
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