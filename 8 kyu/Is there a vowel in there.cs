// -----------------------------------------------------------
// Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).
// 
// If they are, change the array value to a string of that vowel.
// 
// Return the resulting array.
// -----------------------------------------------------------

public class Kata
{
	public static object[] IsVow(object[] a)
	{
		object[] answer = new object[a.Length];
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] is int)
			{
				int num = (int)a[i];
				char c = (char)num;
				if ("aeiou".Contains(c))
				{
					answer[i] = c.ToString();
				}
				else
				{
					answer[i] = num;
				}
			}
			else
			{
				answer[i] = a[i];
			}
		}
		return answer;
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