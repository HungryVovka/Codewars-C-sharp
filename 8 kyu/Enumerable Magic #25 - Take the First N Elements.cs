// -----------------------------------------------------------
// Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.
// 
// If you need help, here's a reference:
// 
// https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
// -----------------------------------------------------------

using System.Linq;

public static class Kata
{
	public static int[] Take(int[] arr, int n)
	{
		return arr.Take(n).ToArray();
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