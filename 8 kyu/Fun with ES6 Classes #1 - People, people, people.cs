// -----------------------------------------------------------
// Fun with ES6 Classes #1 - People, people, people
// Time for some OOP fun!
// 
// Define a class Person with the following properties:
// 
// A constructor that accepts 4 arguments: firstName/FirstName (defaults to "John" if not set), lastName/LastName (defaults to "Doe" if 
// not set), age/Age (defaults to 0 if not set) and gender/Gender (defaults to "Male" if not set). These should be stored in this.firstName/
// this.FirstName, this.lastName/this.LastName, this.age/this.Age and this.gender/this.Gender respectively.
// 
// A method sayFullName/SayFullName that accepts no arguments and returns the full name (e.g. "John Doe")
// 
// A class/static method greetExtraTerrestrials/GreetExtraTerrestrials that accepts one parameter raceName and returns 
// "Welcome to Planet Earth raceName". For example, if the race name is "Martians", it should say "Welcome to Planet Earth Martians"
// 
// You may use any valid syntax you like; however, it is highly recommended that you complete this Kata using ES6 syntax and features.
// 
// Have fun! :D
// -----------------------------------------------------------

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public string Gender { get; set; }
	
	public Person(string firstName = "John", 
				string lastName = "Doe",
				int age = 0,
				string gender = "Male")
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
		Gender = gender;
	}
	
	public string SayFullName()
	{
		return FirstName + " " + LastName;
	}
	
	public static string GreetExtraTerrestrials(string raceName)
	{
		return "Welcome to Planet Earth " + raceName;
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