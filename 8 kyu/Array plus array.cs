// -----------------------------------------------------------
// I'm new to coding and now I want to get the sum of two arrays... Actually the sum of all their elements. I'll appreciate for your help.
// 
// P.S. Each array includes only integer numbers. Output is a number too.
// -----------------------------------------------------------

public static class Kata
{
	public static int ArrayPlusArray(int[] arr1, int[] arr2)
	{
		int sumArr = 0;
		for (int i = 0; i < arr1.Length; i++)
		{
			sumArr += arr1[i];
		}
		for (int j = 0; j < arr2.Length; j++)
		{
			sumArr += arr2[j];
		}
		return sumArr;
	}
}

// or

using System.Linq;

public static class Kata
{
	public static int ArrayPlusArray(int[] arr1, int[] arr2)
	{
		return arr1.Sum() + arr2.Sum();
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