// -----------------------------------------------------------
// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
// 
// Example
// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
// 
// The returned format must be correct in order to complete this challenge.
// 
// Don't forget the space after the closing parentheses!
// -----------------------------------------------------------

using System;

public class Kata
{
	public static string CreatePhoneNumber(int[] numbers)
	{
		string[] arrN = Array.ConvertAll(numbers, i => i.ToString());
		string strN = string.Join("", arrN);
		return $"({strN.Substring(0, 3)}) {strN.Substring(3, 3)}-{strN.Substring(6)}";
	}
}

// or

public class Kata
{
	public static string CreatePhoneNumber(int[] n)
	{
		string phoneNumber = "(" +n[0]+n[1]+n[2] + ") " +n[3]+n[4]+n[5] + "-" +n[6]+n[7]+n[8]+n[9];
		return phoneNumber;
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