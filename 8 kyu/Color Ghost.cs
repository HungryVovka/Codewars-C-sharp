// -----------------------------------------------------------
// Color Ghost
// Create a class Ghost
// 
// Ghost objects are instantiated without any arguments.
// 
// Ghost objects are given a random color attribute of "white" or "yellow" or "purple" or "red" when instantiated
// 
// ghost = new Ghost();
// ghost.color //=> "white" or "yellow" or "purple" or "red"
// -----------------------------------------------------------

using System;

public class Ghost
{
    string[] colorGhost = {"purple", "red", "white", "yellow"};

    public string GetColor(){
        return colorGhost[new Random().Next(0, colorGhost.Length)];
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