// -----------------------------------------------------------
// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that 
// contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
// 
// Example: (Input --> Output)
// 
// "Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)
// 
// isIsogram "Dermatoglyphics" = true
// isIsogram "moose" = false
// isIsogram "aba" = false
// -----------------------------------------------------------

using System.Collections.Generic;

public class Kata
{
	public static bool IsIsogram(string str) 
	{
		string s = str.ToLower();
		if (new HashSet<char>(s).Count == s.Length || s.Length == 0)
		{
			return true;
		}
		return false;
	}
}

// or

using System.Collections.Generic;

public class Kata
{
	public static bool IsIsogram(string str) 
	{
		HashSet<char> s = new HashSet<char>(str.ToUpper());
		return str.Length == s.Count;
	}
}

// or

using System.Linq;

public class Kata
{
	public static bool IsIsogram(string str) 
	{
		return str.Length == str.ToLower().Distinct().Count();
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