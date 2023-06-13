// -----------------------------------------------------------
// There was a test in your class and you passed it. Congratulations!
// But you're an ambitious person. You want to know if you're better than the average student in your class.
// 
// You receive an array with your peers' test scores. Now calculate the average and compare your score!
// 
// Return True if you're better, else False!
// 
// Note:
// Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
	public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
	{
		int average = (int)ClassPoints.Average();
		return YourPoints > average;
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