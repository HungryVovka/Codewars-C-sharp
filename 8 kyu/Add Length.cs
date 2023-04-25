// -----------------------------------------------------------
// What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?
// 
// Example(Input --> Output)
// 
// "apple ban" --> ["apple 5", "ban 3"]
// "you will win" -->["you 3", "will 4", "win 3"]
// 
// Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .
// 
// Note: String will have at least one element; words will always be separated by a space.
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
	public static string[] AddLength(string str)
	{
		return str.Split(" ")
			.Select(i => string.Format("{0} {1}", i, i.Length))
			.ToArray();
	}
}

// or

using System.Linq;

public class Kata
{
	public static string[] AddLength(string str)
	{
		return str.Split(" ").Select(i => $"{i} {i.Length}").ToArray();
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