// -----------------------------------------------------------
// Complete the square sum function so that it squares each number passed into it and then sums the results together.
// 
// For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
// -----------------------------------------------------------

using System;

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sums = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
      sums += (int)Math.Pow(numbers[i], 2);
    }
    return sums;
  }
}