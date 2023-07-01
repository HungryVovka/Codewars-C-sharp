// -----------------------------------------------------------
// The code provided is supposed replace all the dots . in the specified String str with dashes -
// 
// But it's not working properly.
// 
// Task
// Fix the bug so we can all go home early.
// 
// Notes
// String str will never be null.
// -----------------------------------------------------------

using System.Text.RegularExpressions;

public class Kata
{
	public static string ReplaceDots(string str)
	{
		return Regex.Replace(str, @"\.", "-");
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