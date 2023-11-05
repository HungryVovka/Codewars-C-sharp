// -----------------------------------------------------------
// Let's imagine we have a popular online RPG. A player begins with a score of 0 in class E5. A1 is the highest level a player can achieve.
// 
// Now let's say the players wants to rank up to class E4. To do so the player needs to achieve at least 100 points to enter the qualifying stage.
// 
// Write a script that will check to see if the player has achieved at least 100 points in his class. If so, he enters the qualifying stage.
// 
// In that case, we return, "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.".
// 
// Otherwise return, False/false (according to the language in use).
// 
// NOTE
// : Remember, in C# you have to cast your output value to Object type!
// -----------------------------------------------------------

using System;

public class Kata
{
    public static Object PlayerRankUp(int points)
    {
        string qualifying = "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.";
        return points < 100 ? false : qualifying;
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