// -----------------------------------------------------------
// Given an array of integers your solution should find the smallest integer.
// 
// For example:
// 
// Given [34, 15, 88, 2] your solution will return 2
// Given [34, -345, -1, 100] your solution will return -345
// 
// You can assume, for the purpose of this kata, that the supplied array will not be empty.
// -----------------------------------------------------------

public class Kata 
{
	public static int FindSmallestInt(int[] args) 
	{
		int smallest = args[0];
		foreach (int i in args)
		{
			if (i < smallest)
			{
				smallest = i;
			}
		}
		return smallest;
	}
}

// or

using System;
using System.Linq;

public class Kata 
{
	public static int FindSmallestInt(int[] args) 
	{
		return args.Min();
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