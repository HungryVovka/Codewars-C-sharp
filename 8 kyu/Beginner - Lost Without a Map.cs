// -----------------------------------------------------------
// Given an array of integers, return a new array with each value doubled.
// 
// For example:
// 
// [1, 2, 3] --> [2, 4, 6]
// -----------------------------------------------------------

public class Kata
{
	public static int[] Maps(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] *= 2;
		}
		return arr;
	}
}

// or

using System.Linq;

public class Kata
{
	public static int[] Maps(int[] arr)
	{
		return arr.Select(i => i * 2).ToArray();
	}
}

// or

using System;

public class Kata
{
	public static int[] Maps(int[] arr)
	{
		return Array.ConvertAll(arr, i => i * 2);
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