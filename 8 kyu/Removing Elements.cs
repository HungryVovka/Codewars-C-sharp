// -----------------------------------------------------------
// Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.
// 
// Example:
// ["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]
// 
// None of the arrays will be empty, so you don't have to worry about that!
// -----------------------------------------------------------

using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static object[] RemoveEveryOther(object[] arr)
  {
    List<object> answer = new List<object>();
    for (int i = 0; i < arr.Count(); i += 2)
    {
      answer.Add(arr[i]);
    }
    return answer.ToArray();
  }
}

// or

using System.Linq;

public static class Kata
{
  public static object[] RemoveEveryOther(object[] arr)
  {
    return arr.Where((_, i) => i % 2 == 0).ToArray();
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