// -----------------------------------------------------------
// Can you find the needle in the haystack?
// 
// Write a function findNeedle() that takes an array full of junk but containing one "needle"
// 
// After your function finds the needle it should return a message (as a string) that says:
// 
// "found the needle at position " plus the index it found the needle, so:
// 
// Example(Input --> Output)
// 
// ["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"] --> "found the needle at position 5"
// -----------------------------------------------------------

using System;

public class Kata
{
	public static string FindNeedle(object[] haystack)
	{
		int needle = Array.IndexOf(haystack, "needle");
		return $"found the needle at position {needle}";
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