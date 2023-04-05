// -----------------------------------------------------------
// Arrow style Functions
// Come here to practice the Arrow style functions Not much else to say good luck!
// 
// Details
// You will be given an array of numbers which can be used using the String.fromCharCode() (JS), Tools.FromCharCode() (C#) method to convert the 
// number to a character. It is recommended to map over the array of numbers and convert each number to the corresponding ascii character.
// 
// Examples
// These are example of how to convert a number to an ascii Character:
// Javascript => String.fromCharCode(97) // a
// C# => Tools.FromCharCode(97) // a
// 
// Reference: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions
// -----------------------------------------------------------

using System;
using System.Linq;

public class Kata
{
    public static string ArrowFunc(int[] arr)
    {
        return string.Join("", arr.Select(
            number => Tools.FromCharCode(number)).ToArray());
    }
}

// or

using System;
using System.Linq;

public class Kata
{
    public static string ArrowFunc(int[] arr)
    {
        return string.Concat(arr.Select(number => (char)number));
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