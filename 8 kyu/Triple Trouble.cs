// -----------------------------------------------------------
// Triple Trouble
// Create a function that will return a string that combines all of the letters of the three inputed strings in groups. Taking the first letter of all of the 
// inputs and grouping them next to each other. Do this for every letter, see example below!
// 
// E.g. Input: "aa", "bb" , "cc" => Output: "abcabc"
// 
// Note: You can expect all of the inputs to be the same length.
// -----------------------------------------------------------

public class Kata
{
	public static string TripleTrouble(string one, string two, string three)
	{
		string answer = "";
		for (int i = 0; i < one.Length; i++)
		{
			answer += one[i].ToString() + two[i].ToString() + three[i].ToString();
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