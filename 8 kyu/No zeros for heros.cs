// -----------------------------------------------------------
// Numbers ending with zeros are boring.
// 
// They might be fun in your world, but not here.
// 
// Get rid of them. Only the ending ones.
// 
// 1450 -> 145
// 960000 -> 96
// 1050 -> 105
// -1050 -> -105
// 
// Zero alone is fine, don't worry about it. Poor guy anyway
// -----------------------------------------------------------

public class NoBoring 
{
	public static int NoBoringZeros(int n) 
	{
		if (n == 0)
		{
			return n;
		}
		while (n % 10 == 0)
		{
			n = n / 10;
		}
		return n;
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