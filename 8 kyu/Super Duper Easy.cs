// -----------------------------------------------------------
// Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".
// 
// Note: in C#, you'll always get the input as a string, so the above applies if the string isn't representing a double value.
// -----------------------------------------------------------

using System;

public class Kata
{
	public static string Problem(String a)
	{
		try
		{
			return $"{Convert.ToDouble(a) * 50 + 6}";
		}
		catch
		{
			return "Error";
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