// -----------------------------------------------------------
// We need a function that can transform a number (integer) into a string.
// 
// What ways of achieving this do you know?
// 
// Examples (input --> output):
// 123  --> "123"
// 999  --> "999"
// -100 --> "-100"
// -----------------------------------------------------------

using System;

public class Kata
{
	public static string NumberToString(int num)
	{
		return String.Format("{0}", num);
	}
}

// or

using System;

public class Kata
{
	public static string NumberToString(int num)
	{
		return num.ToString();
	}
}

// or

using System;

public class Kata
{
	public static string NumberToString(int num)
	{
		return "" + num;
	}
}

// or

using System;

public class Kata
{
	public static string NumberToString(int num)
	{
		return $"{num}";
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