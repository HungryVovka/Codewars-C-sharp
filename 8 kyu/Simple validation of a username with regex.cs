// -----------------------------------------------------------
// Write a simple regex to validate a username. Allowed characters are:
// 
// lowercase letters,
// numbers,
// underscore
// 
// Length should be between 4 and 16 characters (both included).
// -----------------------------------------------------------

using System.Text.RegularExpressions;

public class Kata
{
	public static bool ValidateUsr(string username) 
	{
		Regex regex = new Regex("^[0-9_a-z]{4,16}$");
		return regex.IsMatch(username);
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