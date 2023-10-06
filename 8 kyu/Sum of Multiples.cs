// -----------------------------------------------------------
// Your Job
// Find the sum of all multiples of n below m
// 
// Keep in Mind
// n and m are natural numbers (positive integers)
// m is excluded from the multiples
// 
// Examples
// Kata.SumMul(2, 9)   => 2 + 4 + 6 + 8 = 20
// Kata.SumMul(3, 13)  => 3 + 6 + 9 + 12 = 30
// Kata.SumMul(4, 123) => 4 + 8 + 12 + ... = 1860
// Kata.SumMul(4, 1)   // throws ArgumentException
// Kata.SumMul(0, 20)  // throws ArgumentException
// -----------------------------------------------------------

using System;

public class Kata
{
	public static int SumMul(int n, int m)
	{
		if ((n <= 0 || m <= 0) || (m <= n))
		{
			throw new ArgumentException();
		}
		int mult = 0;
		for (int i = n; i < m; i += n)
		{
			mult += i;
		}
		return mult;
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