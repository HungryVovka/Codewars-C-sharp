// -----------------------------------------------------------
// I would like to be able to pass an array with two elements to my swapValues function to swap the values. However it appears that the values aren't 
// changing.
// 
// Can you figure out what's wrong here?
// -----------------------------------------------------------

public class Swapper
{
	public object[] Arguments { get; private set; }
		
	public Swapper(object[] args)
	{
		Arguments = args;
	}
	
	public void SwapValues()
	{
		object[] args = new[] { Arguments[0], Arguments[1] };
		object temp = args[0];
		args[0] = args[1];
		args[1] = temp;
		Arguments = args;
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