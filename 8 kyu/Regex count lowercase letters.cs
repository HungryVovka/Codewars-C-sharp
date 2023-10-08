// -----------------------------------------------------------
// Your task is simply to count the total number of lowercase letters in a string.
// 
// Examples
// "abc" ===> 3
// 
// "abcABC123" ===> 3
// 
// "abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~" ===> 3
// 
// "" ===> 0;
// 
// "ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~" ===> 0
// 
// "abcdefghijklmnopqrstuvwxyz" ===> 26
// -----------------------------------------------------------

using System.Text.RegularExpressions;

public class Kata
{
	public static int LowercaseCountCheck(string s)
	{
		Regex regex = new Regex("[a-z]");
		var matches = regex.Matches(s);
		return matches.Count;
	}
}

// or

using System.Linq;

public class Kata
{
	public static int LowercaseCountCheck(string s)
	{
		return s.Count(char.IsLower);
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