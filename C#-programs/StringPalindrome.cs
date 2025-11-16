//Check if a string is palindrome or not
using System;
class HelloWorld {
  static void Main() {
      string str = "ttygegegytt";
      bool res = IsPalindromeString(str);
      Console.WriteLine(res+"");
  }
  
  public static bool IsPalindromeString(string str)
  {
      string temp="";
      for(int i=str.Length-1;i>=0;i--)
      {
          temp=temp+str[i];
      }
      return temp.Equals(str);
  }
}