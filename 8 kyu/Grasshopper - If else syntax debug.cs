// -----------------------------------------------------------
// If/else syntax debug
// 
// While making a game, your partner, Greg, decided to create a function to check if the user is still alive called 
// checkAlive/CheckAlive/check_alive. Unfortunately, Greg made some errors while creating the function.
// 
// checkAlive/CheckAlive/check_alive should return true if the player's health is greater than 0 or false if it is 0 or below.
// -----------------------------------------------------------

public class Player
{
	private int health = 100;
	public int Health
	{
		get
		{
			return this.health;
		}
		set
		{
			health = value;
		}
	}
	
	public Player()
	{
		
	}
	
	//FIXME: This method won't compile for some reason! :(
	public bool CheckAlive()
	{
		return this.Health > 0;
	}
}

// or

public class Player
{
	public int Health {get; set;} = 100;
	public Player(){}
	public bool CheckAlive()
	{
		return this.Health > 0;
	}
}

// or

public class Player
{
	public int Health {get; set;} = 100;
	public Player(){}
	public bool CheckAlive() => this.Health > 0;
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