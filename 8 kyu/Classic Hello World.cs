// -----------------------------------------------------------
// You are given a method called main, make it print the line Hello World!, (yes, that includes a new line character at the end) and don't return 
// anything
// 
// Note that for some languages, the function main is the entry point of the program.
// 
// Here's how it will be tested:
// 
//    Solution.Main("parameter1", "parameter2","parametern")
// 
// Hints:
// 
// Check your references
// 
// Think about the scope of your method
// 
// For prolog you can use write but there are better ways
// 
// If you still don't get it probably you can define main as an attribute of the Solution class that accepts a single argument, and that only prints 
// "Hello World!" without any return.
// -----------------------------------------------------------

using System;

class Solution
{
	public static void Main(string[] parameter)
	{
		Console.WriteLine("Hello World!");
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