//RemoveDupChars from a string
using System;
using System.Text;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
      string str = "Hey Ashish"; //output:- uoy era hsihsA
      string res = RemoveDupChars(str);
      Console.WriteLine(res+"");
  }
  
  public static string RemoveDupChars(string str)
  {
      StringBuilder builder = new StringBuilder();
      
      string message = str.Replace(" ",string.Empty);
      while(message.Length != 0)
      {
          char current = message[0];
          builder.Append(current);
          message = message.Replace(current.ToString(),string.Empty);
      }
      return builder.ToString();
  }
}