// -----------------------------------------------------------
// You are given a list of numbers (positive / negative integers) and you need to get the nearest entries of a given value.
// 
// For example:
// 
// The number 10 is given and you need to get the nearest number in this series: 1, 2, 3, 4, 6, 12. The answer should be 12.
// 
// C#
// 
// int[] intArray = new int[] {1,2,3,4,6,12};
// int givenValue = 10;
// 
// RoundUp(givenValue, intArray) => {12};
// 
// PHP
// 
// $intArray   = [1,2,3,4,6,12];
// $givenValue = 10;
// 
// roundUp($givenValue, $intArray) => [12];
// 
// If the given number is 5, the result should be {4,6};
// 
// C#
// 
// int[] intArray = new int[] {1,2,3,4,6,12};
// int givenValue = 5;
// 
// RoundUp(givenValue, intArray) => {4,6};
// 
// PHP
// 
// $intArray   = [1,2,3,4,6,12];
// $givenValue = 5;
// 
// roundUp($givenValue, $intArray) => [4, 6];
// 
// If the method gets an empty array, it will return an empty array.
// 
// C#
// 
// int[] intArray = new int[] {};
// int givenValue = 42;
// 
// RoundUp(givenValue, intArray) => {};
// 
// PHP
// 
// $intArray   = [];
// $givenValue = 42;
// 
// roundUp($givenValue, $intArray) => [];
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static int[] RoundUp(int number, int[] list)
	{
		if (list.Length == 0)
		{
			return new int[0];
		}
		int nearest = list.Min(i => Math.Abs(i - number));
		return list
			.Where(j => Math.Abs(j - number) == nearest)
			.ToArray();
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