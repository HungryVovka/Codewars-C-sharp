// -----------------------------------------------------------
// You'll be given a string, and have to return the sum of all characters as an int. The function should be able to handle all printable ASCII characters.
// 
// Examples:
// 
// uniTotal("a") == 97
// uniTotal("aaa") == 291
// -----------------------------------------------------------

public class Kata
{
	public static int UniTotal(string str)
	{
		int total = 0;
		char[] arr = str.ToCharArray();
		foreach (char c in arr)
		{
			total += (int)c;
		}
		return total;
	}
}

// or

using System.Linq;

public class Kata
{
	public static int UniTotal(string str)
	{
		return str.Sum(c => (int)c);
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