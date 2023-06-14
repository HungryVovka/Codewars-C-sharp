// -----------------------------------------------------------
// It's the academic year's end, fateful moment of your school report. The averages must be calculated. All the students come to you and entreat you to 
// calculate their average for them. Easy ! You just need to write a script.
// 
// Return the average of the given array rounded down to its nearest integer.
// 
// The array will never be empty.
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
	public static int GetAverage(int[] marks)
	{
		int arrsum = marks.Sum();
		return (int)Math.Floor((double)arrsum / marks.Length);
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