// -----------------------------------------------------------
// Switch/Case - Bug Fixing #6
// 
// Oh no! Timmy's evalObject function doesn't work. He uses Switch/Cases to evaluate the given properties of an object, can you fix timmy's function?
// -----------------------------------------------------------

using System;

public class Kata
{
	public static double EvalObject(double value1, double value2, char operation)
	{
		switch(operation)
		{
			case '+': return value1 + value2;
			case '-': return value1 - value2;
			case '/': return value1 / value2;
			case '*': return value1 * value2;
			case '%': return value1 % value2;
			case '^': return Math.Pow(value1, value2);
			default: return 0;
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