// -----------------------------------------------------------
// Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.
// 
// You need to consider the following ratings:
// 
// Terrible: tip 0%
// Poor: tip 5%
// Good: tip 10%
// Great: tip 15%
// Excellent: tip 20%
// 
// The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:
// 
// "Rating not recognised" in Javascript, Python and Ruby...
// ...or null in Java
// ...or -1 in C#
// 
// Because you're a nice person, you always round up the tip, regardless of the service.
// -----------------------------------------------------------

using System;
using System.Collections.Generic;

public class Kata
{  
	public static int CalculateTip(double amount, string rating)
	{
		Dictionary<string, double> tips = new Dictionary<string, double>()
		{
			{ "terrible" , 0.0 },
			{ "poor" , 0.05 },
			{ "good" , 0.1 },
			{ "great" , 0.15 },
			{ "excellent" , 0.2 }
		};
		rating = rating.ToLower();
		return tips.ContainsKey(rating) ? 
			(int)Math.Ceiling(tips[rating] * amount) : 
			-1;
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