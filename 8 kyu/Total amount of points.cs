// -----------------------------------------------------------
// Our football team has finished the championship.
// 
// Our team's match results are recorded in a collection of strings. Each match is represented by a string in the format "x:y", where x is our team's 
// score and y is our opponents score.
// 
// For example: ["3:1", "2:2", "0:1", ...]
// 
// Points are awarded for each match as follows:
// 
// if x > y: 3 points (win)
// if x < y: 0 points (loss)
// if x = y: 1 point (tie)
// 
// We need to write a function that takes this collection and returns the number of points our team (x) got in the championship by the rules given 
// above.
// 
// Notes:
// 
// our team always plays 10 matches in the championship
// 0 <= x <= 4
// 0 <= y <= 4
// -----------------------------------------------------------

public static class Kata
{
	public static int TotalPoints(string[] games)
	{
		int score = 0;
		foreach (var g in games)
		{
			if (g[0] > g[2])
			{
				score = score + 3;
			}
			else if (g[0] < g[2])
			{
				score = score + 0;
			}
			else if (g[0] == g[2])
			{
				score = score + 1;
			}
		}
		return score;
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