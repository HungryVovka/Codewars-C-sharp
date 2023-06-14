// -----------------------------------------------------------
// Write a function to split a string and convert it into an array of words.
// 
// Examples (Input ==> Output):
// "Robin Singh" ==> ["Robin", "Singh"]
// 
// "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
// -----------------------------------------------------------

namespace Solution
{
	using System.Linq;

	public class Solution
	{
		public static string[] StringToArray(string str)
		{
			return str.Split(" ").ToArray();
		}
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