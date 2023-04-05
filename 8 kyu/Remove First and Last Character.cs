// -----------------------------------------------------------
// It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the 
// original string. You don't have to worry with strings with less than two characters.
// -----------------------------------------------------------

using System;

public class Kata
{
    public static string Remove_char(string s)
    {
    	string answer = s.Remove(s.Length - 1, 1).Remove(0, 1);
    	return answer;
    }
}

// or

using System;

public class Kata
{
    public static string Remove_char(string s)
    {
    	return s.Substring(1, s.Length - 2);
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