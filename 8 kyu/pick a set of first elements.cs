// -----------------------------------------------------------
// Write a function to get the first element(s) of a sequence. Passing a parameter n (default=1) will return the first n element(s) of the sequence.
// 
// If n == 0 return an empty sequence []
// 
// Examples
// var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
// Kata.TakeFirstElements(arr); //=> new object[] { 'a' }
// Kata.TakeFirstElements(arr, 2);// => new object[] { 'a', 'b' }
// Kata.TakeFirstElements(arr, 3); //=> new object[] { 'a', 'b', 'c' }
// Kata.TakeFirstElements(arr, 0); //=> new object[] { }
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
	public static object[] TakeFirstElements(object[] array, int n = 1)
	{
		return array.Take(n).ToArray();
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