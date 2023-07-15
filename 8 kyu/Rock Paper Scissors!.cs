// -----------------------------------------------------------
// Rock Paper Scissors
// Let's play! You have to return which player won! In case of a draw return Draw!.
// 
// Examples(Input1, Input2 --> Output):
// 
// "scissors", "paper" --> "Player 1 won!"
// "scissors", "rock" --> "Player 2 won!"
// "paper", "paper" --> "Draw!"
// -----------------------------------------------------------

public class Kata
{
	public string Rps(string p1, string p2)
	{
		if (p1 == p2)
		{
			return "Draw!";
		}
		else if ((p1 == "rock" && p2 == "paper") |
				 (p1 == "paper" && p2 == "scissors") |
				 (p1 == "scissors" && p2 == "rock"))
		{
			return "Player 2 won!";
		}
		else
		{
			return "Player 1 won!";
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