// -----------------------------------------------------------
// Given an array of integers.
// 
// Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive 
// nor negative.
// 
// If the input is an empty array or is null, return an empty array.
// 
// Example
// For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
// -----------------------------------------------------------

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return new int[0];
        }
        int posArr = 0;
        int negArr = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                posArr += 1;
            }
            else
            {
                negArr += arr[i];
            }
        }
        return new int[] {posArr, negArr};
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