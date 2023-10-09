// -----------------------------------------------------------
// Write a method, that will get an integer array as parameter and will process every number from this array.
// 
// Return a new array with processing every number of the input-array like this:
// 
// If the number has an integer square root, take this, otherwise square the number.
// 
// Example
// [4,3,9,7,2,1] -> [2,9,3,49,4,1]
// 
// Notes
// The input array will always contain only positive numbers, and will never be empty or null.
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static int[] SquareOrSquareRoot(int[] array)
	{
		Func<int, int> squareCheck = num => 
		{
			double sqrtNum = Math.Sqrt(num);
			if (sqrtNum % 1.0 == 0.0)
			{
				return (int)sqrtNum;
			}
			else
			{
				return num * num;
			}
		};
		return array.Select(squareCheck).ToArray();
	}
}

// or

using System;
using System.Linq;

public class Kata
{
	public static int[] SquareOrSquareRoot(int[] array)
	{
		return array.Select(num => 
		{
			int sqrtNum = (int)Math.Sqrt(num);
			if (sqrtNum * sqrtNum == num)
			{
				return sqrtNum;
			}
			else
			{
				return num * num;
			}
		}).ToArray();
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