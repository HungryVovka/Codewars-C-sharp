// -----------------------------------------------------------
// Write a function that will check if two given characters are the same case.
// 
// If either of the characters is not a letter, return -1
// If both characters are the same case, return 1
// If both characters are letters, but not the same case, return 0
// 
// Examples
// 'a' and 'g' returns 1
// 
// 'A' and 'C' returns 1
// 
// 'b' and 'G' returns 0
// 
// 'B' and 'g' returns 0
// 
// '0' and '?' returns -1
// -----------------------------------------------------------

public class Kata
{
	public static int SameCase(char a, char b)
	{
		string lowLet = "abcdefghijklmnopqrstuvwxyz";
		if (!lowLet.ToLower().Contains(char.ToLower(a)) || 
				!lowLet.ToLower().Contains(char.ToLower(b)))
		{
			return -1;
		}
		return CaseCompare(a) == CaseCompare(b) ? 1 : 0;
	}
	
	public static string CaseCompare(char c)
	{
		if (c == char.ToLower(c))
		{
			return "lower";
		}
		else
		{
			return "upper";
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