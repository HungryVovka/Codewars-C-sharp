// -----------------------------------------------------------
// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
// 
// Note: input will never be an empty string
// -----------------------------------------------------------

public class Kata
{
	public static string FakeBin(string x)
	{
		string binstr = "";
		foreach (char i in x)
		{
			if (int.Parse(i.ToString()) < 5)
			{
				binstr += "0";
			}
			else
			{
				binstr += "1";
			}
		}
		return binstr;
	}
}

// or

using System.Linq;

public class Kata
{
	public static string FakeBin(string x)
	{
		return string.Concat(
			x.Select(i => int.Parse(i.ToString()) < 5 ? "0" : "1"));
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