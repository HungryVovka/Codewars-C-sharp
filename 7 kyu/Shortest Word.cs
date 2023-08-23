// -----------------------------------------------------------
// Simple, given a string of words, return the length of the shortest word(s).
// 
// String will never be empty and you do not need to account for different data types.
// -----------------------------------------------------------

using System;

public class Kata
{
	public static int FindShort(string s)
	{
		string[] l = s.Split(" ");
		int w = int.MaxValue;
		foreach (var word in l)
		{
			w = Math.Min(word.Length, w);
		}
		return w;
	}
}

// or

using System.Linq;

public class Kata
{
	public static int FindShort(string s)
	{
		return s.Split(" ").Min(i => i.Length);
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