// -----------------------------------------------------------
// Task
// Two players - "black" and "white" are playing a game. The game consists of several rounds. If a player wins in a round, he is to move again during 
// the next round. If a player loses a round, it's the other player who moves on the next round. Given whose turn it was on the previous round and 
// whether he won, determine whose turn it is on the next round.
// 
// Input/Output
// [input] string lastPlayer/$last_player
// 
// "black" or "white" - whose move it was during the previous round.
// 
// [input] boolean win/$win
// 
// true if the player who made a move during the previous round won, false otherwise.
// 
// [output] a string
// 
// Return "white" if white is to move on the next round, and "black" otherwise.
// 
// Example
// For lastPlayer = "black" and win = false, the output should be "white".
// 
// For lastPlayer = "white" and win = true, the output should be "white".
// -----------------------------------------------------------

public class Kata
{
	public static string WhoseMove(string lastPlayer, bool win)
	{
		if (win)
		{
			return lastPlayer;
		}
		else
		{
			if (lastPlayer == "white") return "black";
			if (lastPlayer == "black") return "white"; 
		}
		return null;
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