// -----------------------------------------------------------
// Complete the solution so that it reverses the string passed into it.
// 
// 'world'  =>  'dlrow'
// 'word'   =>  'drow'
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static string Solution(string str)
	{
		char[] arr = str.ToCharArray();
		Array.Reverse(arr);
		return new string(arr);
	}
}

// or

using System;
using System.Linq;

public static class Kata
{
	public static string Solution(string str) 
	{
		return new string(str.ToArray().Reverse().ToArray());
	}
}

// or

using System;
using System.Linq;

public static class Kata
{
	public static string Solution(string str) 
	{
		return string.Concat(str.Reverse());
	}
}