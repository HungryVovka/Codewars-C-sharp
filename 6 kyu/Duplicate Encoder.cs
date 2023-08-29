// -----------------------------------------------------------
// The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the 
// original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a 
// duplicate.
// 
// Examples
// "din"      =>  "((("
// "recede"   =>  "()()()"
// "Success"  =>  ")())())"
// "(( @"     =>  "))((" 
// 
// Notes
// Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is the expected 
// result, not the input!
// -----------------------------------------------------------

using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    word = word.ToLower();
    string answer = "";
    foreach (char i in word)
    {
      if (word.Count(x => x == i) > 1)
      {
        answer += ")";
      }
      else
      {
        answer += "(";
      }
    }
    return answer;
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