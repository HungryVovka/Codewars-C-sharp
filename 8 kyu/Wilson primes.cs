// -----------------------------------------------------------
// Wilson primes satisfy the following condition. Let P represent a prime number.
// 
// Then,
// 
// ((P-1)! + 1) / (P * P)
// 
// should give a whole number.
// 
// Your task is to create a function that returns true if the given number is a Wilson prime.
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
	public static bool AmIWilson(int p)
	{
		int[] wilsonPrimes = new int[] { 5, 13, 563 };
		return wilsonPrimes.Contains(p);
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