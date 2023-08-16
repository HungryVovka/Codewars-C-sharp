// -----------------------------------------------------------
// Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the 
// name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
// 
// Examples:
// 
// spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
// spinWords( "This is a test") => returns "This is a test" 
// spinWords( "This is another test" )=> returns "This is rehtona test"
// -----------------------------------------------------------

using System;
using System.Collections.Generic;

public class Kata
{
	public static string SpinWords(string sentence)
	{
		List<string> reversed = new List<string>();
		string[] splStr = sentence.Split(' ');
		for (int i = 0; i < splStr.Length; i++)
		{
			if (splStr[i].Length > 4)
			{
				char[] arr = splStr[i].ToCharArray();
				Array.Reverse(arr);
				reversed.Add(new string(arr));
			}
			else
			{
				reversed.Add(splStr[i]);
			}
		}
		return string.Join(" ", reversed);
	}
}

// or

using System;

public class Kata
{
	public static string SpinWords(string sentence)
	{
		string[] splStr = sentence.Split(' ');
		string[] reversed = new string[splStr.Length];
		for (int i = 0; i < splStr.Length; i++)
		{
			if (splStr[i].Length > 4)
			{
				char[] arr = splStr[i].ToCharArray();
				Array.Reverse(arr);
				reversed[i] = new string(arr);
			}
			else
			{
				reversed[i] = splStr[i];
			}
		}
		return string.Join(" ", reversed);
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