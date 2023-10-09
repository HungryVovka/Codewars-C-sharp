// -----------------------------------------------------------
// Create an any? (JS: any) function that accepts an array and a block (JS: function), and returns true if the block (/function) returns true for any item in 
// the array. If the array is empty, the function should return false.
// 
// Ruby: If you get stuck, you can read up here:
// 
// http://www.rubycuts.com/enum-any
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static bool Any(int[] arr, Func<int,bool> fun)
	{
		return arr.Count(fun) > 0;
	}
}

// or

using System;
using System.Linq;

public class Kata
{
	public static bool Any(int[] arr, Func<int,bool> fun)
	{
		return arr.Any(fun);
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