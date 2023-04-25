// -----------------------------------------------------------
// Create a class Ball. Ball objects should accept one argument for "ball type" when instantiated.
// 
// If no arguments are given, ball objects should instantiate with a "ball type" of "regular."
// 
// ball1 = new Ball();
// ball2 = new Ball("super");
// 
// ball1.ballType     //=> "regular"
// ball2.ballType     //=> "super"
// -----------------------------------------------------------

public class Ball
{
	public string ballType
	{
		get;
		set; 
	}
	
	public Ball(string ballType = "regular")
	{
		this.ballType = ballType;
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