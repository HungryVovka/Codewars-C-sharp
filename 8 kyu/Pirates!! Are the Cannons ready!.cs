// -----------------------------------------------------------
// Ahoy Matey!
// 
// Welcome to the seven seas.
// 
// You are the captain of a pirate ship.
// 
// You are in battle against the royal navy.
// 
// You have cannons at the ready.... or are they?
// 
// Your task is to check if the gunners are loaded and ready, if they are: Fire!
// 
// If they aren't ready: Shiver me timbers!
// 
// Your gunners for each test case are 2, 3 or 4.
// 
// When you check if they are ready their answers are in a dictionary and will either be: aye or nay
// 
// Firing with less than all gunners ready is non-optimum (this is not fire at will, this is fire by the captain's orders or walk the plank, dirty sea-dog!)
// 
// If all answers are 'aye' then Fire! if one or more are 'nay' then Shiver me timbers!
// -----------------------------------------------------------

using System.Collections.Generic;

public static class Kata
{
	public static string CannonsReady(Dictionary<string, string> gunners)
	{
		string ready = "Fire!";
		string notReady = "Shiver me timbers!";
		if (gunners.ContainsValue("nay"))
		{
			return notReady;
		}
		return ready;
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