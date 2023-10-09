// -----------------------------------------------------------
// Task Overview
// Given a non-negative integer n, write a function to_binary/ToBinary which returns that number in a binary format.
// 
// Documentation:
// Kata.ToBinary Method (Int32)
// Returns the binary representation of a non-negative integer as an integer.
// 
// Syntax
// 
// public static int ToBinary(
// int n
//   )
// 
// Parameters
// n
// Type: System.Int32
// The integer to convert.
// 
// Return Value
// Type: System.Int32
// The binary representation of the argument as an integer.
// 
// to_binary(1)  /* should return 1 */
// to_binary(5)  /* should return 101 */
// to_binary(11) /* should return 1011 */
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static int ToBinary(int n)
	{
		string binary = "";
		if (n != 0)
		{
			while (n >= 1)
			{
				if (n % 2 == 0)
				{
					binary += "0";
					n = n / 2;
				}
				else
				{
					binary += "1";
					n = (n - 1) / 2;
				}
			}
		}
		else 
		{
			binary = "0";
		}
		return Convert.ToInt32(ReverseString(binary));
	}
	
	private static string ReverseString(string s)
	{
		char[] charArr = s.ToCharArray();
		Array.Reverse(charArr);
		return new string(charArr);
	}
}

// or

using System;

public static class Kata
{
	public static int ToBinary(int n)
	{
		return Convert.ToInt32(Convert.ToString(n, 2));
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