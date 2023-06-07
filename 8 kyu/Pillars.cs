// -----------------------------------------------------------
// There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three 
// arguments:
// 
// number of pillars (≥ 1);
// distance between pillars (10 - 30 meters);
// width of the pillar (10 - 50 centimeters).
// 
// Calculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).
// -----------------------------------------------------------

public static class Kata
{
	public static int Pillars(int numPill, int dist, int width)
	{
		if (numPill == 1)
		{
			return 0;
		}
		else
		{
			return (numPill - 1) * (dist * 100) + (numPill - 2) * width;
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