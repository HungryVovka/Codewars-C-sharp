// -----------------------------------------------------------
// Given a string s, write a method (function) that will return true if its a valid single integer or floating number or false if its not.
// 
// Valid examples, should return true:
// 
// isDigit("3")
// isDigit("  3  ")
// isDigit("-3.23")
// 
// should return false:
// 
// isDigit("3-4")
// isDigit("  3   5")
// isDigit("3 5")
// isDigit("zero")
// -----------------------------------------------------------

using System.Text.RegularExpressions;

public class CodeWars
{
	public static bool IsDigit(string s) 
	{
		if (s == null)
		{
			return false;
		}
		return Regex.IsMatch(s, @"^-?\d*\.?\d+$");
	}
}

// or

public class CodeWars
{
	public static bool IsDigit(string s) 
	{
		return double.TryParse(s, out _);
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