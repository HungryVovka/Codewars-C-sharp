// -----------------------------------------------------------
// Messi goals function
// Messi is a soccer player with goals in three leagues:
// 
// LaLiga
// Copa del Rey
// Champions
// Complete the function to return his total number of goals in all three leagues.
// 
// Note: the input will always be valid.
// 
// For example:
// 
// 5, 10, 2  -->  17
// -----------------------------------------------------------


public class Kata
{
	public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
	{
		return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
	}
}

// or

using System.Linq;

public class Kata
{
	public static int GetGoals(params int[] goals)
	{
		return goals.Sum();
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