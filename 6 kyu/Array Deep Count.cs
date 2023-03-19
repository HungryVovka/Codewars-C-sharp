// -----------------------------------------------------------
// You are given an array. Complete the function that returns the number of ALL elements within an array, including any nested arrays.
// 
// Examples
// []                   -->  0
// [1, 2, 3]            -->  3
// ["x", "y", ["z"]]    -->  4
// [1, 2, [3, 4, [5]]]  -->  7
// 
// The input will always be an array.
// -----------------------------------------------------------

public class Kata{
  public static int DeepCount(object array){
    int answer = 0;
    object[] newArr = (object[])array;
    foreach (object i in newArr){
      if (i is object[]){
        answer += DeepCount(i);
      }
      answer += 1;
    }
    return answer;
  }
}

// or

public class Kata{
  public static int DeepCount(object array){
    object[] newArr = (object[])array;
    int answer = newArr.Length;
    for (int i = 0; i < newArr.Length; i++){
      if (newArr[i] is object[]){
        answer += DeepCount(newArr[i]);
      }
    }
    return answer;
  }
}