// -----------------------------------------------------------
// Your friend invites you out to a cool floating pontoon around 1km off the beach. Among other things, the pontoon has a huge slide that drops you out 
// right into the ocean, a small way from a set of stairs used to climb out.
// 
// As you plunge out of the slide into the water, you see a shark hovering in the darkness under the pontoon... Crap!
// 
// You need to work out if the shark will get to you before you can get to the pontoon. To make it easier... as you do the mental calculations in the water 
// you either freeze when you realise you are dead, or swim when you realise you can make it!
// 
// You are given 5 variables;
// 
// sharkDistance = distance from the shark to the pontoon. The shark will eat you if it reaches you before you escape to the pontoon.
// 
// sharkSpeed = how fast it can move in metres/second.
// 
// pontoonDistance = how far you need to swim to safety in metres.
// 
// youSpeed = how fast you can swim in metres/second.
// 
// dolphin = a boolean, if true, you can half the swimming speed of the shark as the dolphin will attack it.
// 
// The pontoon, you, and the shark are all aligned in one dimension.
// 
// If you make it, return "Alive!", if not, return "Shark Bait!".
// -----------------------------------------------------------

public class Kata
{
	public static string Shark
		(
		int pontoonDistance, 
		int sharkDistance, 
		int youSpeed, 
		int sharkSpeed, 
		bool dolphin
	)
		
	{
		double pontoon = (double)pontoonDistance / youSpeed;
		double shark = (double)sharkDistance / sharkSpeed * ((dolphin ? 1 : 0) + 1);
		return pontoon < shark ? "Alive!" : "Shark Bait!";
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