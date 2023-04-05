// -----------------------------------------------------------
// Write function bmi that calculates body mass index (bmi = weight / height2).
// 
// if bmi <= 18.5 return "Underweight"
// 
// if bmi <= 25.0 return "Normal"
// 
// if bmi <= 30.0 return "Overweight"
// 
// if bmi > 30 return "Obese"
// -----------------------------------------------------------

using System;

public class Kata
{
	public static string Bmi(double weight, double height)
	{
		double bmi = weight / Math.Pow(height, 2);
		if (bmi <= 18.5)
		{
			return "Underweight";
		}
		else if (bmi <= 25.0)
		{
			return "Normal";
		}
		else if (bmi <= 30.0)
		{
			return "Overweight";
		}
		else
		{
			return "Obese";
		}
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