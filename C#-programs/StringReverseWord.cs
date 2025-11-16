//reverse each word in a given string..
//Ex:- Hey Ashish, output:- yeH hsihsA

//reverse a string
using System;
using System.Text;
class HelloWorld {
  static void Main() {
      string str = "Armstrong went to the moon"; //output:- uoy era hsihsA
      string res = ReverseEachWord(str);
      Console.WriteLine(res+"");
  }
  
  public static string ReverseEachWord(string str)
  {
      //start = 0, end = 0
      //iterate from front. when a ' ' found stop. increment end
      
      int start = 0;
      int end = 0;
      int i;
      StringBuilder reversedWord = new StringBuilder();
      
      while(end <= str.Length - 1)
      {
          if(str[end] == ' ')
          {
              i = end - 1;
              while(i >= start)
              {
                  reversedWord.Append(str[i]);
                  i--;
              }
              reversedWord.Append(' ');
              start = end + 1;
          }
          end++;
      }
      for(int j = end-1;j>=start;j--)
      {
          reversedWord.Append(str[j]);
      }
      return reversedWord.ToString();
      
  }
}

// //ReverseEachWord in a string
// using System;
// using System.Text;
// using System.Collections.Generic;
// class HelloWorld {
//   static void Main() {
//       string str = "uoy era hsihsA"; //output:- uoy era hsihsA
//       string res = ReverseEachWord(str);
//       Console.WriteLine(res+"");
//   }
  
//   public static string ReverseEachWord(string str)
//   {
//       //start = 0, end = 0
//       //iterate from front. when a ' ' found stop. increment end
//       StringBuilder reverseWord = new StringBuilder();
//       List<char> charlist = new List<char>();
      
//       for(int i = 0;i<str.Length;i++)
//       {
//           if(str[i] == ' ' || i == str.Length - 1)
//           {
//               if(i == str.Length-1)
//               {
//                   charlist.Add(str[i]);
//               }
//               for(int j=charlist.Count - 1;j>=0;j--)
//               {
//                  reverseWord.Append(charlist[j]);
//               }
//               if(i != str.Length)
//               {
//                   reverseWord.Append(' ');
//               }
//               charlist.Clear();
//           }
//           else
//           {
//               charlist.Add(str[i]);
//           }
//       }
//       return reverseWord.ToString();
      
//   }
// }