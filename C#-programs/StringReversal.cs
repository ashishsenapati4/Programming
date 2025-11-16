//reverse a string
using System;
class HelloWorld {
  static void Main() {
      string str = "tom4355jj";
      string res = ReverseString(str);
      Console.WriteLine(res+"");
  }
  
  public static string ReverseString(string str)
  {
      string temp="";
      for(int i=str.Length-1;i>=0;i--)
      {
          temp=temp+str[i];
      }
      return temp;
  }
}