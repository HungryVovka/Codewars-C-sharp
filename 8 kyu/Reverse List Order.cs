// -----------------------------------------------------------
// In this kata you will create a function that takes in a list and returns a list with the reverse order.
// 
// Examples (Input -> Output)
// * [1, 2, 3, 4]  -> [4, 3, 2, 1]
// * [9, 2, 0, 7]  -> [7, 0, 2, 9]
// -----------------------------------------------------------

using System.Collections.Generic;

public class Kata
{
	public static List<int> ReverseList(List<int> list)
	{
		List<int> reverseListOrder = new List<int>();
		for (int i = list.Count - 1; i >= 0; i--)
		{
			reverseListOrder.Add(list[i]);
		}
		return reverseListOrder;
	}
}

// or

using System.Linq;
using System.Collections.Generic;

public class Kata
{
	public static List<int> ReverseList(List<int> list)
	{
		return Enumerable.Reverse(list).ToList();
	}
}


// or

using System.Linq;
using System.Collections.Generic;

public class Kata
{
	public static List<int> ReverseList(List<int> list)
	{
		return list.AsEnumerable().Reverse().ToList();
	}
}

// or

using System.Linq;
using System.Collections.Generic;

public class Kata
{
	public static List<int> ReverseList(IEnumerable<int> list)
	{
		return list.Reverse().ToList();
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