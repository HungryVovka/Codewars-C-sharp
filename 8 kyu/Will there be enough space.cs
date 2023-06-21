// -----------------------------------------------------------
// The Story:
// Bob is working as a bus driver. However, he has become extremely popular amongst the city's residents. With so many passengers wanting to get 
// aboard his bus, he sometimes has to face the problem of not enough space left on the bus! He wants you to write a simple program telling him if he 
// will be able to fit all the passengers.
// 
// Task Overview:
// You have to write a function that accepts three parameters:
// 
// cap is the amount of people the bus can hold excluding the driver.
// on is the number of people on the bus excluding the driver.
// wait is the number of people waiting to get on to the bus excluding the driver.
// 
// If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.
// 
// Usage Examples:
// cap = 10, on = 5, wait = 5 --> 0 # He can fit all 5 passengers
// cap = 100, on = 60, wait = 50 --> 10 # He can't fit 10 of the 50 waiting
// 
// Documentation:
// Kata.Enough Method (Int32, Int32, Int32)
// Returns the number of passengers the bus cannot fit, or 0 if the bus can fit every passenger.
// 
// Syntax
// 
// public static int Enough(
// int cap,
//   int on,
// int wait
//   )
// 
// Parameters
// cap
// Type: System.Int32
// The amount of people that can fit on the bus excluding the driver.
// 
// on
// Type: System.Int32
// The amount of people on the bus excluding the driver.
// 
// wait
// Type: System.Int32
// The amount of people waiting to enter the bus.
// 
// Return Value
// Type: System.Int32
// An integer representing how many passengers cannot fit on the bus, or 0 if every passenger can fit on the bus.
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static int Enough(int cap, int on, int wait)
	{
		int space = cap - on - wait;
		return space < 0 ? Math.Abs(space) : 0;
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