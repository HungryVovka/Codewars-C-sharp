// -----------------------------------------------------------
// In this Kata we are passing a number (n) into a function.
// 
// Your code will determine if the number passed is even (or not).
// 
// The function needs to return either a true or false.
// 
// Numbers may be positive or negative, integers or floats.
// 
// Floats with decimal part non equal to zero are considered UNeven for this kata.
// -----------------------------------------------------------

public class Number
{
	public bool IsEven(double n)
	{
		return n % 2 == 0;
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