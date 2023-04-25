// -----------------------------------------------------------
// In this simple exercise, you will create a program that will take two lists of integers, a and b. Each list will consist of 3 positive integers above 0, 
// representing the dimensions of cuboids a and b. You must find the difference of the cuboids' volumes regardless of which is bigger.
// 
// For example, if the parameters passed are ([2, 2, 3], [5, 4, 1]), the volume of a is 12 and the volume of b is 20. Therefore, the function 
// should return 8.
// 
// Your function will be tested with pre-made examples as well as random ones.
// 
// If you can, try writing it in one line of code.
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static int FindDifference(int[] a, int[] b)
	{
		int aAgg = a.Aggregate(1, (i, j) => i * j);
		int bAgg = b.Aggregate(1, (i, j) => i * j);
		return Math.Abs(aAgg - bAgg);
	}
}

// or

using System;

public class Kata
{
	public static int FindDifference(int[] a, int[] b)
	{
		return Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2]));
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