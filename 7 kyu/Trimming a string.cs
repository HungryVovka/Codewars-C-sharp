// -----------------------------------------------------------
// Create a function that will trim a string (the first argument given) if it is longer than the requested maximum string length (the second argument 
// given). The result should also end with "..."
// 
// These dots at the end also add to the string length.
// 
// For example, trim("Creating kata is fun", 14) should return "Creating ka..."
// 
// If the string is smaller or equal than the maximum string length, then simply return the string with no trimming or dots required.
// 
// e.g. trim("Code Wars is pretty rad", 50) should return "Code Wars is pretty rad"
// 
// If the requested string length is smaller than or equal to 3 characters, then the length of the dots is not added to the string length.
// 
// e.g. trim("He", 1) should return "H...", because 1 <= 3
// 
// Requested maximum length will be greater than 0. Input string will not be empty.
// -----------------------------------------------------------

using System;

public class TrimStringKata
{
    public static string TrimString(string phrase, int size)
    {
    	if (phrase.Length <= size)
    	{
    		return phrase;
    	}
    	else
    	{
    		if (size > 3)
    		{
    			return phrase.Substring(0, size - 3) + "...";
    		}
    		else
    		{
    			return phrase.Substring(0, size) + "...";
    		}
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