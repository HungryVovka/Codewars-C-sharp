// -----------------------------------------------------------
// This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
// -----------------------------------------------------------

public class Multiplier{
  public static int Multiply(int x){
    return x % 2 == 0 ? x * 8 : x * 9;
  }
}  