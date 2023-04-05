// -----------------------------------------------------------
// Create a public class called Cube without a constructor which gets one single private integer variable Side, a getter GetSide() and a setter 
// SetSide(int num) method for this property. Actually, getter and setter methods are not the common way to write this code in C#. In the next kata of 
// this series, we gonna refactor the code and make it a bit more professional...
// 
// Notes:
// 
// There's no need to check for negative values!
// initialise the side to 0.
// -----------------------------------------------------------

using System;

public class Cube
{
    private System.Int32 side = 0;
    public System.Int32 GetSide()
    {
        return side;
    }
    public void SetSide(System.Int32 num)
    {
        side = num;
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