//count ocurence of each character in a string..
//Ex:- tomatina , t -> 2, o -> 1, m -> 1, a -> 2 i -> 1, n -> 1 . . . .

//ReverseEachWord in a string
using System;
using System.Text;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
      string str = "homemaker"; //output:- uoy era hsihsA
      CountCharacter(str);
  }
  
  public static void CountCharacter(string str)
  {
      string message = str.Replace(" ",string.Empty);
      Console.WriteLine(message);
      while(message.Length != 0)
      {
          int count = 0;
          char current = message[0];
          for(int j=0;j<message.Length;j++)
          {
              if(current == message[j])
              {
                  count++;
              }
          }
          Console.WriteLine("Character: "+current+" -> "+count);
          
          message = message.Replace(current.ToString(),string.Empty);
      }
  }
}
