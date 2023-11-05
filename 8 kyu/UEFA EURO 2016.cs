// -----------------------------------------------------------
// Finish the uefaEuro2016() function so it return string just like in the examples below:
// 
// uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
// uefaEuro2016(['Belgium', 'Italy'],[0, 2]) // "At match Belgium - Italy, Italy won!"
// uefaEuro2016(['Portugal', 'Iceland'],[1, 1]) // "At match Portugal - Iceland, teams played draw."
// -----------------------------------------------------------

public class Kata
{
	public static string UefaEuro2016(string[] teams, int[] scores)
	{
		if (scores[0] > scores[1])
		{
			return $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
		}
		else if (scores[0] < scores[1])
		{
			return $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
		}
		else
		{
			return $"At match {teams[0]} - {teams[1]}, teams played draw.";
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