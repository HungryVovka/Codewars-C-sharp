// -----------------------------------------------------------
// This function should return an object, but it's not doing what's intended. What's wrong?
// -----------------------------------------------------------

using System.Collections.Generic;

public class Kata
{
	public static Dictionary<string,string> Mystery(
		Dictionary<string, string> returnToSanity = null
	)
	{
		if (returnToSanity == null)
		{
			return new Dictionary<string, string> { { "sanity", "hello" } };
		}
		return returnToSanity;
	}
}

// or

using System.Collections.Generic;

public class Kata
{
	public static Dictionary<string,string> Mystery()
	{
		return new() { { "sanity", "hello" } };
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