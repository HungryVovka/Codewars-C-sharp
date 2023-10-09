// -----------------------------------------------------------
// Complete the function which converts hex number (given as a string) to a decimal number.
// -----------------------------------------------------------

using System;

public class Kata
{
	public static int HexToDec(string hexString)
	{
		if (hexString.StartsWith("-"))
		{
			hexString = hexString.Substring(1);
			return -(Convert.ToInt32(hexString, 16));
		}
		return Convert.ToInt32(hexString, 16);
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