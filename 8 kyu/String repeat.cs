// -----------------------------------------------------------
// Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
// 
// Examples (input -> output)
// 6, "I"     -> "IIIIII"
// 5, "Hello" -> "HelloHelloHelloHelloHello"
// -----------------------------------------------------------

namespace Solution
{
	public static class Program
	{
		public static string RepeatStr(int n, string s)
		{
			string answer = "";
			for (int i = 0; i < n; i++)
			{
				answer += s;
			}
			return answer;
		}
	}
}

// or

using System;
using System.Linq;

namespace Solution
{
	public static class Program
	{
		public static string RepeatStr(int n, string s)
		{
			return String.Concat(Enumerable.Repeat(s, n));
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