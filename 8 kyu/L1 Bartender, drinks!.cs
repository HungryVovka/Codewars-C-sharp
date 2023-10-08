// -----------------------------------------------------------
// Complete the function that receives as input a string, and produces outputs according to the following table:
// 
// Input                        Output
// "Jabroni"                    "Patron Tequila"
// "School Counselor"           "Anything with Alcohol"
// "Programmer"                 "Hipster Craft Beer"
// "Bike Gang Member"           "Moonshine"
// "Politician"                 "Your tax dollars"
// "Rapper"                     "Cristal"
// anything else                "Beer"
// 
// Note: anything else is the default case: if the input to the function is not any of the values in the table, then the return value should be "Beer".
// 
// Make sure you cover the cases where certain words do not show up with correct capitalization. For example, the input "pOLitiCIaN" should still 
// return "Your tax dollars".
// -----------------------------------------------------------

using System.Collections.Generic;

public class Kata
{
	public static string GetDrinkByProfession(string p)
	{
		Dictionary<string, string> Drinks = new Dictionary<string, string>
		{
			{ "JABRONI", "Patron Tequila" },
			{ "SCHOOL COUNSELOR", "Anything with Alcohol" },
			{ "PROGRAMMER", "Hipster Craft Beer" },
			{ "BIKE GANG MEMBER", "Moonshine" },
			{ "POLITICIAN", "Your tax dollars" },
			{ "RAPPER", "Cristal" }
		};
		return Drinks.ContainsKey(p.ToUpper()) ? Drinks[p.ToUpper()] : "Beer";
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