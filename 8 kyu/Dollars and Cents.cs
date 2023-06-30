// -----------------------------------------------------------
// The company you work for has just been awarded a contract to build a payment gateway. In order to help move things along, you have volunteered 
// to create a function that will take a float and return the amount formatting in dollars and cents.
// 
// 39.99 becomes $39.99
// 
// The rest of your team will make sure that the argument is sanitized before being passed to your function although you will need to account for 
// adding trailing zeros if they are missing (though you won't have to worry about a dangling period).
// 
// Examples:
// 
// 3 needs to become $3.00
// 
// 3.1 needs to become $3.10
// 
// Good luck! Your team knows they can count on you!
// -----------------------------------------------------------

public class Kata
{
	public static string FormatMoney(double amount)
	{
		return string.Format("${0:0.00}", amount);
	}
}

// or

public class Kata
{
	public static string FormatMoney(double amount)
	{
		return string.Format("${0:f}", amount);
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