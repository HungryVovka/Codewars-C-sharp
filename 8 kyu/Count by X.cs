// -----------------------------------------------------------
// Create a function with two arguments that will return an array of the first n multiples of x.
// 
// Assume both the given number and the number of times to count will be positive numbers greater than 0.
// 
// Return the results as an array or list ( depending on language ).
// 
// Examples
// countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
// countBy(2,5)  should return {2,4,6,8,10}
// -----------------------------------------------------------

using System.Collections.Generic;

public static class Kata
{
	public static int[] CountBy(int x, int n)
	{
		List<int> z = new List<int>();
		int a = x;
		while (a <= x * n)
		{
			z.Add(a);
			a += x;
		}
		return z.ToArray();
	}
}

// or

using System.Linq;

public static class Kata
{
	public static int[] CountBy(int x, int n)
	{
		return Enumerable.Range(1, n)
			.Select(a => a * x)
			.ToArray();
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