// -----------------------------------------------------------
// Create a function called _if which takes 3 arguments: a value bool and 2 functions (which do not take any parameters): func1 and func2
// 
// When bool is truthy, func1 should be called, otherwise call the func2.
// 
// Example:
// Kata.If(true, () => Console.WriteLine("True"), () => Console.WriteLine("False"));
// // write "True" to console
// -----------------------------------------------------------

using System;

public class Kata
{
	public static void If(bool condition, Action func1, Action func2)
	{
		if (condition == true)
		{
			func1();
		}
		else 
		{
			func2();
		}
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