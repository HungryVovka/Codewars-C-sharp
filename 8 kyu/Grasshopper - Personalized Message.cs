// -----------------------------------------------------------
// Create a function that gives a personalized greeting. This function takes two parameters: name and owner.
// 
// Use conditionals to return the proper message:
// 
// case                 	return
// name equals owner        'Hello boss'
// otherwise                'Hello guest'
// -----------------------------------------------------------

public class Kata
{
	public static string Greet(string name, string owner)
	{
		return name == owner ? "Hello boss" : "Hello guest";
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