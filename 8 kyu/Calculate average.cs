// -----------------------------------------------------------
// Write a function which calculates the average of the numbers in a given list.
// 
// Note: Empty arrays should return 0.
// -----------------------------------------------------------

using System.Linq;

class AverageSolution
{
	public static double FindAverage(double[] array)
	{
		if (array.Length == 0)
		{
			return 0;
		}
		else
		{
			return array.Sum() / (double)array.Length;
		}
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