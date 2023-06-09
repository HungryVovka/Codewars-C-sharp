// -----------------------------------------------------------
// Build a function that returns an array of integers from n to 1 where n>0.
// 
// Example : n=5 --> [5,4,3,2,1]
// -----------------------------------------------------------

using System.Collections.Generic;

public static class Kata
{
	public static int[] ReverseSeq(int n)
	{
		List<int> arr = new List<int>();
		for (int i = n; i > 0; i--)
		{
			arr.Add(i);
		}
		return arr.ToArray();
	}
}

// or

using System.Linq;

public static class Kata
{
	public static int[] ReverseSeq(int n)
	{
		return Enumerable.Range(1, n).Reverse().ToArray();
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