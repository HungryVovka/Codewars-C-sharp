// -----------------------------------------------------------
// You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the 
// text that should be displayed next to such an item.
// 
// Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the 
// examples:
// 
// []                                -->  "no one likes this"
// ["Peter"]                         -->  "Peter likes this"
// ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
// ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
// ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
// 
// Note: For 4 or more names, the number in "and 2 others" simply increases.
// -----------------------------------------------------------

public static class Kata
{
	public static string Likes(string[] name)
	{
		name = name ?? new string[0];
		switch(name.Length)
		{
			case 0:
				return "no one likes this";
			case 1:
				return name[0] + " likes this";
			case 2:
				return name[0] + " and " + name[1] + " like this";
			case 3:
				return name[0] + ", " + name[1] + " and " + name[2] + " like this";
			default:
				return name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
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