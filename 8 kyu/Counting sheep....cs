// -----------------------------------------------------------
// Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in 
// the array (true means present).
// 
// For example,
// 
// [true,  true,  true,  false,
//   true,  true,  true,  true ,
//   true,  false, true,  false,
//   true,  false, false, true ,
//   true,  true,  true,  true ,
//   false, false, true,  true]
// 
// The correct answer would be 17.
// 
// Hint: Don't forget to check for bad values like null/undefined
// -----------------------------------------------------------

using System;

public static class Kata
{
	public static int CountSheeps(bool[] sheeps)
	{
		int answer = 0;
		for (int sheep = 0; sheep < sheeps.Length; sheep++)
		{
			if (sheeps[sheep] == true)
			{
				answer += 1;
			}
		}
		return answer;
	}
}

// or

using System;
using System.Linq;

public static class Kata
{
	public static int CountSheeps(bool[] sheeps)
	{
		return sheeps.Count(sheep => sheep == true);
	}
}