// -----------------------------------------------------------
// Your goal is to return multiplication table for number that is always an integer from 1 to 10.
// 
// For example, a multiplication table (string) for number == 5 looks like below:
// 
// 1 * 5 = 5
// 2 * 5 = 10
// 3 * 5 = 15
// 4 * 5 = 20
// 5 * 5 = 25
// 6 * 5 = 30
// 7 * 5 = 35
// 8 * 5 = 40
// 9 * 5 = 45
// 10 * 5 = 50
// 
// P. S. You can use \n in string to jump to the next line.
// 
// Note: newlines should be added between rows, but there should be no trailing newline at the end. If you're unsure about the format, look at the 
// sample tests.
// -----------------------------------------------------------

public static class Kata
{
	public static string MultiTable(int number)
	{
		string tab = "";
		for (int i = 1; i < 11; i++)
		{
			tab += $"{i} * {number} = {i * number}\n";
		}
		return tab.Substring(0, tab.Length - 1);
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