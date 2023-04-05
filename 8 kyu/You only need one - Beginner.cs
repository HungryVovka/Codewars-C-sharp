// -----------------------------------------------------------
// You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.
// 
// Array can contain numbers or strings. X can be either.
// 
// Return true if the array contains the value, false if not.
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static bool Check(object[] a, object x)
	{
		return a.Contains(x);
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