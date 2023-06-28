// -----------------------------------------------------------
// Write a function get_char() / getChar() which takes a number and returns the corresponding ASCII char for that value.
// 
// Example:
// 
// get_char(65)
// 
// should return:
// 
// 'A'
// 
// For ASCII table, you can refer to http://www.asciitable.com/
// -----------------------------------------------------------

using System;

public class Kata
{
	public static char GetChar(int charcode)
	{
		return Convert.ToChar(charcode);
	}
}

// or

public class Kata
{
	public static char GetChar(int charcode)
	{
		return (char)charcode;
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