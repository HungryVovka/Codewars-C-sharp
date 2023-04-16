// -----------------------------------------------------------
// A square of squares
// You like building blocks. You especially like building blocks that are squares. And what you even like more, is to arrange them into a square of square 
// building blocks!
// 
// However, sometimes, you can't arrange them into a square. Instead, you end up with an ordinary rectangle! Those blasted things! If you just had a 
// way to know, whether you're currently working in vain… Wait! That's it! You just have to check if your number of building blocks is a perfect square.
// 
// Task
// Given an integral number, determine if it's a square number:
// 
// In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer 
// with itself.
// 
// The tests will always use some integral number, so don't worry about that in dynamic typed languages.
// 
// Examples
// -1  =>  false
//  0  =>  true
//  3  =>  false
//  4  =>  true
// 25  =>  true
// 26  =>  false
// -----------------------------------------------------------

using System;

public class Kata
{
	public static bool IsSquare(int n)
	{
		int squareN = (int)Math.Sqrt(n);
		return n == (int)Math.Pow(squareN, 2);
	}
}

// or

using System;

public class Kata
{
	public static bool IsSquare(int n)
	{
		double squareN = Math.Sqrt(n);
		return squareN % 1.0 == 0.0;
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