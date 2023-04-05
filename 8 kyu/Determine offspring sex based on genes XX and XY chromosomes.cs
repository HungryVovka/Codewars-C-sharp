// -----------------------------------------------------------
// The male gametes or sperm cells in humans and other mammals are heterogametic and contain one of two types of sex chromosomes. They are 
// either X or Y. The female gametes or eggs however, contain only the X sex chromosome and are homogametic.
// 
// The sperm cell determines the sex of an individual in this case. If a sperm cell containing an X chromosome fertilizes an egg, the resulting zygote will 
// be XX or female. If the sperm cell contains a Y chromosome, then the resulting zygote will be XY or male.
// 
// Determine if the sex of the offspring will be male or female based on the X or Y chromosome present in the male's sperm.
// 
// If the sperm contains the X chromosome, return "Congratulations! You're going to have a daughter."; If the sperm contains the Y chromosome, 
// return "Congratulations! You're going to have a son.";
// -----------------------------------------------------------

public class Kata
{
	public static string ChromosomeCheck(string sperm)
	{
		string kid = "";
		if (sperm == "XY")
		{
			kid = "son";
		}
		else if (sperm == "XX")
		{
			kid = "daughter";
		}
		return $"Congratulations! You're going to have a {kid}.";
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