// -----------------------------------------------------------
// Given a non-empty array of integers, return the result of multiplying the values together in order. Example:
// 
// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
// -----------------------------------------------------------

public class Kata
{
	public static int Grow(int[] arr)
	{
		int answer = 1;
		foreach (int i in arr)
		{
			answer *= i;
		}
		return answer;
	}
}