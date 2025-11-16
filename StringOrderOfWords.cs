//reverse order of words...

using System;
using System.Text;

class HelloWorld {
  static void Main() {
      string str = "How the hell are you eating";
      string reversedStr = ReverseOrderOfWords(str);
      Console.WriteLine(reversedStr+"");
  }
  
  public static string ReverseOrderOfWords(string str)
  {
      //take start and end pointer 
      //decrement start when a space ' ' is found stop and increment i until
      //end is reached.
      //update end as start - 1, this will be new end
      //for last word iterate till end pointer and return result.
      int i;
      StringBuilder reversedSentence = new StringBuilder();
      
      int start = str.Length - 1;
      int end = str.Length - 1;
      
      while(start >= 0)
      {
          if(str[start] == ' ')
          {
              i = start + 1;
              while(i <= end)
              {
                  reversedSentence.Append(str[i]);
                  i++;
              }
              reversedSentence.Append(' ');
              end = start - 1;
          }
          start --;
      }
      for(int j=0;j<=end;j++)
      {
          reversedSentence.Append(str[j]);
      }
      return reversedSentence.ToString();
      
  }
}