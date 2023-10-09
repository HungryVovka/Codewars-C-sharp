// -----------------------------------------------------------
// Issue
// Looks like some hoodlum plumber and his brother has been running around and damaging your stages again.
// 
// The pipes connecting your level's stages together need to be fixed before you receive any more complaints.
// 
// The pipes are correct when each pipe after the first is 1 more than the previous one.
// 
// Task
// Given a list of unique numbers sorted in ascending order, return a new list so that the values increment by 1 for each index from the minimum value 
// up to the maximum value (both included).
// 
// Example
// Input:  1,3,5,6,7,8 Output: 1,2,3,4,5,6,7,8
// -----------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

public class Fixer
{
	public static List<int> PipeFix(List<int> numbers)
	{
		int maxpipe = numbers.Max();
		int minpipe = numbers.Min();
		return Enumerable.Range(minpipe, maxpipe - minpipe + 1).ToList();
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