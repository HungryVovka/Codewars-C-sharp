// -----------------------------------------------------------
// Sometimes, I want to quickly be able to convert miles per imperial gallon (mpg) into kilometers per liter (kpl).
// 
// Create an application that will display the number of kilometers per liter (output) based on the number of miles per imperial gallon (input).
// 
// Make sure to round off the result to two decimal points.
// 
// Some useful associations relevant to this kata:
// 
// 1 Imperial Gallon = 4.54609188 litres
// 1 Mile = 1.609344 kilometres
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static double Converter(int mpg)
	{
		double gallon = 4.54609188;
		double mile = 1.609344;
		double x = (double)mpg * mile / gallon;
		return Math.Round(x, 2);
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