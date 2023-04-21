// -----------------------------------------------------------
// Story:
// You are going to make toast fast, you think that you should make multiple pieces of toasts and once. So, you try to make 6 pieces of toast.
// 
// Problem:
// You forgot to count the number of toast you put into there, you don't know if you put exactly six pieces of toast into the toasters.
// 
// Define a function that counts how many more (or less) pieces of toast you need in the toasters. Even though you need more or less, the number will 
// still be positive, not negative.
// 
// Examples:
// You must return the number of toast the you need to put in (or to take out). In case of 5 you can still put 1 toast in:
// 
// six_toast(5) == 1
// 
// And in case of 12 you need 6 toasts less (but not -6):
// 
// six_toast(12) == 6
// 
// Good luck!
// -----------------------------------------------------------

public class Kata
{
	public static int SixToast(int num)
	{
		return num >= 6 ? num - 6 : 6 - num;
	}
}

// or

using System;

public class Kata
{
	public static int SixToast(int num)
	{
		return Math.Abs(num - 6);
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