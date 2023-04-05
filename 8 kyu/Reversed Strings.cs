// -----------------------------------------------------------
// Complete the solution so that it reverses the string passed into it.
// 
// 'world'  =>  'dlrow'
// 'word'   =>  'drow'
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static string Solution(string str)
	{
		char[] arr = str.ToCharArray();
		Array.Reverse(arr);
		return new string(arr);
	}
}

// or

using System;
using System.Linq;

public static class Kata
{
	public static string Solution(string str) 
	{
		return new string(str.ToArray().Reverse().ToArray());
	}
}

// or

using System;
using System.Linq;

public static class Kata
{
	public static string Solution(string str) 
	{
		return string.Concat(str.Reverse());
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