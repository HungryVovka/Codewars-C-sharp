// -----------------------------------------------------------
// Create a method each_cons that accepts a list and a number n, and returns cascading subsets of the list of size n, like so:
// 
// each_cons([1,2,3,4], 2)
//   #=> [[1,2], [2,3], [3,4]]
// 
// each_cons([1,2,3,4], 3)
//   #=> [[1,2,3],[2,3,4]]
//   
// As you can see, the lists are cascading; ie, they overlap, but never out of order.
// -----------------------------------------------------------

using System.Linq;
using System.Collections.Generic;

static class Kata 
{
	public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
	{
		List<IEnumerable<int>> arr = new List<IEnumerable<int>>();
		for (int i = 0; i <= list.Length - n; i++)
		{
			arr.Add(list.Skip(i).Take(n));
		}
		return arr;
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