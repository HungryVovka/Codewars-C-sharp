// -----------------------------------------------------------
// You get any card as an argument. Your task is to return the suit of this card (in lowercase).
// 
// Our deck (is preloaded):
// 
// string[] Deck =
// {
//     "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
//     "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
//     "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
//     "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
// };
// 
// DefineSuit("3♣") -> return "clubs"
// DefineSuit("3♦") -> return "diamonds"
// DefineSuit("3♥") -> return "hearts"
// DefineSuit("3♠") -> return "spades"
// -----------------------------------------------------------

using System.Collections.Generic;

namespace Solution
{
	public partial class Kata
	{
		public static string DefineSuit(string card)
		{
			var suits = new Dictionary<char, string>
			{
				{'♣', "clubs"},
				{'♦', "diamonds"},
				{'♥', "hearts"},
				{'♠', "spades"}
			};
			return suits[card[card.Length - 1]];
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