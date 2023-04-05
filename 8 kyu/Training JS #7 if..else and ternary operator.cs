// -----------------------------------------------------------
// In JavaScript, if..else is the most basic conditional statement, it consists of three parts:condition, statement1, statement2, like this:
// 
// if (condition) { doThis(); } 
// else           { doThat(); } // Note: This code is valid with or without brackets, but it is strongly recommended to use brackets.
// 
// It means that if the condition is true, then execute the statementa, otherwise execute the statementb. If the statementa or statementb are more 
// than one line, you need to add { and } at the head and tail of statements in JS, to keep the same indentation on Python and to put an end in Ruby 
// where it indeed ends.
// 
// For example, if we want to judge whether a number is odd or even, we can write code like this:
// 
// public static string OddEven(int n)
// {
//   if (n % 2 == 0) { return "even number"; }
//   else            { return "odd number"; }
// }
// 
// If there is more than one condition to judge, we can use the compound if...else statement. For example:
// 
// public static string OldYoung(int age)
// {
//   if (age < 16)      { return "children"; }
//   else if (age < 50) { return "young man"; } // use "else if" if needed
//   else               { return "old man"; }
// }
// 
// This function returns a different value depending on the parameter age.
// 
// Looks very complicated? Well, JS and Ruby also support the ternary operator and Python has something similar too:
// 
// condition ? DoThis() : DoThat();
// 
// Condition and statement separated by "?", different statement separated by ":" in both Ruby and JS; in Python you put the condition in the middle of 
// two alternatives. The two examples above can be simplified with ternary operator:
// 
// public static int OldYoung(int age)
// {
//   return age < 16 ? "children" : age < 50 ? "young man" : "old man";
// }
// 
// Task:
// Complete function saleHotdogs/SaleHotDogs/sale_hotdogs, function accepts 1 parameter:n, n is the number of hotdogs a customer will buy, 
// different numbers have different prices (refer to the following table), return how much money will the customer spend to buy that number of 
// hotdogs.
// 
// number of hotdogs			price per unit (cents)
// n < 5						100
// n >= 5 and n < 10			95
// n >= 10						90
// 
// You can use if..else or ternary operator to complete it.
// 
// When you have finished the work, click "Run Tests" to see if your code is working properly.
// 
// In the end, click "Submit" to submit your code and pass this kata.
// -----------------------------------------------------------

public class Kata
{
	public static int SaleHotDogs(int n)
	{
		if (n < 5) return n * 100;
		if (10 > n && n >= 5) return n * 95;
		if (n >= 10) return n * 90;
		return 0;
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