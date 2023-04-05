// -----------------------------------------------------------
// Given a non-empty array of integers, return the result of multiplying the values together in order. Example:
// 
// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
// -----------------------------------------------------------

public class Kata
{
	public static int Grow(int[] arr)
	{
		int answer = 1;
		foreach (int i in arr)
		{
			answer *= i;
		}
		return answer;
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