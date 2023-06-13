// -----------------------------------------------------------
// Complete the solution so that it reverses all of the words within the string passed in.
// 
// Words are separated by exactly one space and there are no leading or trailing spaces.
// 
// Example(Input --> Output):
// 
// "The greatest victory is that which requires no battle" --> "battle no requires which that is victory greatest The"
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
	public static string ReverseWords(string str)
	{
		return string.Join(" ", str.Split(" ").Reverse());
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