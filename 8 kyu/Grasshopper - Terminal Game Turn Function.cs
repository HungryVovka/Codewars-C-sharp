// -----------------------------------------------------------
// Terminal game turn function
// You are creating a text-based terminal version of your favorite board game. In the board game, each turn has six steps that must happen in this 
// order: roll the dice, move, combat, get coins, buy more health, and print status.
// 
// You are using a library (Game.Logic in C#) that already has the functions below. Create a function named doTurn/DoTurn/do_turn that calls the 
// functions in the proper order as described in the paragraph above.
// 
// - Combat
// - BuyHealth
// - GetCoins
// - PrintStatus
// - RollDice
// - Move
// -----------------------------------------------------------

using static Game.Logic;

public class Kata
{
	public static void DoTurn()
	{
		RollDice();
		Move();
		Combat();
		GetCoins();
		BuyHealth();
		PrintStatus();
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