// -----------------------------------------------------------
// Your task is to find the nearest square number, nearest_sq(n) or nearestSq(n), of a positive integer n.
// 
// For example, if n = 111, then nearest\_sq(n) (nearestSq(n)) equals 121, since 111 is closer to 121, the square of 11, than 100, the square of 10.
// 
// If the n is already the perfect square (e.g. n = 144, n = 81, etc.), you need to just return n.
// 
// Good luck :)
// 
// Check my other katas:
// 
// Alphabetically ordered
// 
// Case-sensitive!
// 
// Not prime numbers
// 
// Find your caterer
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static int NearestSq(int n)
	{
		int sqBefore = (int)Math.Pow(Math.Floor(Math.Sqrt(n)), 2);
		int sqAfter = (int)Math.Pow(Math.Floor(Math.Sqrt(n) + 1), 2);
		if (Math.Abs(n - sqBefore) < Math.Abs(n - sqAfter))
		{
			return sqBefore;
		}
		else
		{
			return sqAfter;
		}
	}
}

// or

using System;

public static class Kata
{
	public static int NearestSq(int n)
	{
		return (int)Math.Pow(Math.Round(Math.Sqrt(n)), 2);
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