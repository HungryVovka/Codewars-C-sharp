// -----------------------------------------------------------
// This is a spin off of my first kata.
// 
// You are given a string containing a sequence of character sequences separated by commas.
// 
// Write a function which returns a new string containing the same character sequences except the first and the last ones but this time separated by 
// spaces.
// 
// If the input string is empty or the removal of the first and last items would cause the resulting string to be empty, return an empty value (represented 
// as a generic value NULL in the examples below).
// 
// Examples
// "1,2,3"      =>  "2"
// "1,2,3,4"    =>  "2 3"
// "1,2,3,4,5"  =>  "2 3 4"
// 
// ""     =>  NULL
// "1"    =>  NULL
// "1,2"  =>  NULL
// -----------------------------------------------------------

public static class Kata
{
	public static string Array(string s)
	{
		string[] arr = s.Split(',');
		if (arr.Length <= 2)
		{
			return null;
		}
		return string.Join(" ", arr[1..^1]);
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