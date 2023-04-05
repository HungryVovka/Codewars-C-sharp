// -----------------------------------------------------------
// You are given an array. Complete the function that returns the number of ALL elements within an array, including any nested arrays.
// 
// Examples
// []                   -->  0
// [1, 2, 3]            -->  3
// ["x", "y", ["z"]]    -->  4
// [1, 2, [3, 4, [5]]]  -->  7
// 
// The input will always be an array.
// -----------------------------------------------------------

public class Kata
{
    public static int DeepCount(object array)
    {
        int answer = 0;
        object[] newArr = (object[])array;
        foreach (object i in newArr){
            if (i is object[]){
                answer += DeepCount(i);
            }
            answer += 1;
        }
        return answer;
    }
}

// or

public class Kata
{
    public static int DeepCount(object array)
    {
        object[] newArr = (object[])array;
        int answer = newArr.Length;
        for (int i = 0; i < newArr.Length; i++){
            if (newArr[i] is object[]){
                answer += DeepCount(newArr[i]);
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