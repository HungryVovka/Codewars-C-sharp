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