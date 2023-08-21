// -----------------------------------------------------------
// In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
// 
// Example
// 
// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
// -----------------------------------------------------------

using System.Collections.Generic;

public class ListFilterer
{
	public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
	{
		List<int> arr = new List<int>();
		for (int i = 0; i < listOfItems.Count; i++)
		{
			if (listOfItems[i] is int)
			{
				 arr.Add((int)listOfItems[i]);
			}
		}
		return arr;
	}
}

// or

using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
	public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
	{
		return listOfItems.OfType<int>();
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