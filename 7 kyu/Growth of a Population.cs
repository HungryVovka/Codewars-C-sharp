// -----------------------------------------------------------
// In a small town the population is p0 = 1000 at the beginning of a year. The population regularly increases by 2 percent per year and moreover 50 
// new inhabitants per year come to live in the town. How many years does the town need to see its population greater or equal to p = 1200 
// inhabitants?
// 
// At the end of the first year there will be: 
// 1000 + 1000 * 0.02 + 50 => 1070 inhabitants
// 
// At the end of the 2nd year there will be: 
// 1070 + 1070 * 0.02 + 50 => 1141 inhabitants (** number of inhabitants is an integer **)
// 
// At the end of the 3rd year there will be:
// 1141 + 1141 * 0.02 + 50 => 1213
// 
// It will need 3 entire years.
// 
// More generally given parameters:
// 
// p0, percent, aug (inhabitants coming or leaving each year), p (population to equal or surpass)
// 
// the function nb_year should return n number of entire years needed to get a population greater or equal to p.
// 
// aug is an integer, percent a positive or null floating number, p0 and p are positive integers (> 0)
// 
// Examples:
// nb_year(1500, 5, 100, 5000) -> 15
// nb_year(1500000, 2.5, 10000, 2000000) -> 10
// 
// Note:
// Don't forget to convert the percent parameter as a percentage in the body of your function: if the parameter percent is 2 you have to convert it to 
// 0.02.
// -----------------------------------------------------------

class Arge
{
	public static int NbYear(int p0, double percent, int aug, int p)
	{
		int year = 0;
		while (p0 < p)
		{
			p0 += (int)(p0 * percent * 0.01) + aug;
			year++;
		}
		return year;
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