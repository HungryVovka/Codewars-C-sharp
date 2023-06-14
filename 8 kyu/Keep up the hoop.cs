// -----------------------------------------------------------
// Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him
// 
// Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message :)
// 
// If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
// If he doesn't get 10 hoops, return the string "Keep at it until you get it".
// -----------------------------------------------------------

public class Kata
{
	public static string HoopCount(int n)
	{
		string hope = "Keep at it until you get it";
		string hoop = "Great, now move on to tricks";
		return n < 10 ? hope : hoop;
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