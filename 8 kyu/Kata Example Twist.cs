// -----------------------------------------------------------
// This is an easy twist to the example kata (provided by Codewars when learning how to create your own kata).
// 
// Add the value "codewars" to the array websites 1,000 times.
// -----------------------------------------------------------

public static class Kata 
{
	public static string[] Websites = new string[1000];
	static Kata()
	{
		for (int i = 0; i < Websites.Length; i++)
		{
			Websites[i] = "codewars";
		}
	}
}

// or

using System.Linq;

public static class Kata 
{
	public static string[] Websites = Enumerable
		.Repeat("codewars", 1000).ToArray();
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