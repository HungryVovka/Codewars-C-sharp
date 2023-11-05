// -----------------------------------------------------------
// Task
// Create a method all which takes two params:
// 
// a sequence
// a function (function pointer in C)
// 
// and returns true if the function in the params returns true for every element in the sequence. Otherwise, it should return false. If the sequence is 
// empty, it should return true, since technically nothing failed the test.
// 
// Example
// all((1, 2, 3, 4, 5), greater_than_9) -> false
// all((1, 2, 3, 4, 5), less_than_9)    -> True
// 
// Help
// Here's a (Ruby) resource if you get stuck:
// 
// http://www.rubycuts.com/enum-all
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static bool All(int[] arr, Func<int, bool> fun)
	{
		return arr.All(fun);
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