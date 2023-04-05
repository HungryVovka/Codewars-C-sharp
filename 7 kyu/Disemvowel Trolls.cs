// -----------------------------------------------------------
// Trolls are attacking your comment section!
// 
// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
// 
// Your task is to write a function that takes a string and return a new string with all vowels removed.
// 
// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
// 
// Note: for this kata y isn't considered a vowel.
// -----------------------------------------------------------


using System;
using System.Text;

public static class Kata
{
    public static string Disemvowel(string str)
    {
    	StringBuilder disemvowelTrolls = new StringBuilder(str);
    	disemvowelTrolls.Replace("a", "");
    	disemvowelTrolls.Replace("A", "");
    	disemvowelTrolls.Replace("e", "");
    	disemvowelTrolls.Replace("E", "");
    	disemvowelTrolls.Replace("i", "");
    	disemvowelTrolls.Replace("I", "");
    	disemvowelTrolls.Replace("o", "");
    	disemvowelTrolls.Replace("O", "");
    	disemvowelTrolls.Replace("u", "");
    	disemvowelTrolls.Replace("U", "");
    	return disemvowelTrolls.ToString();
    }
}

// or

using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Disemvowel(string str)
    {
    	return Regex.Replace(str, "[aAeEiIoOuU]", "");
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