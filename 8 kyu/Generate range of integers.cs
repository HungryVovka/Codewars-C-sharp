// -----------------------------------------------------------
// Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max, with 
// the step. The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min < max)
// 
// Task
// Implement a function named
// 
// GenerateRange(2, 10, 2) == new int[]{ 2, 4, 6, 8, 10 }
// GenerateRange(1, 10, 3) == new int[]{ 1, 4, 7, 10 }
// 
// Note
// min < max
// step > 0
// the range does not HAVE to include max (depending on the step)
// -----------------------------------------------------------

using System.Collections.Generic;

public class Kata
{
	public static int[] GenerateRange(int min, int max, int step)
	{
		List<int> arr = new List<int>();
		for (int i = min; i <= max; i += step)
		{
			arr.Add(i);
		}
		return arr.ToArray();
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