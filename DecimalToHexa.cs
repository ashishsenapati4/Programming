//decimal to Hexadecimal..
using System;
using System.Text;

class HelloWorld {
  static void Main() {
      string hexa = ConvertToHexa(3189897);
      
      StringBuilder revStr = new StringBuilder();
      for(int i=hexa.Length-1;i>=0;i--)
      {
          revStr.Append(hexa[i]);
      }
      Console.WriteLine("0x"+revStr);
  }
  
  public static string ConvertToHexa(int num)
  {
      StringBuilder str = new StringBuilder();
      
      int rem = 0;
      while(num != 0)
      {
          rem = num % 16;
          num /= 16;
          if(rem > 9)
          {
              string s = ParseRem(rem);
              str.Append(s);
          }
          else
          {
              str.Append(rem);
          }
      }
      return str.ToString();
  }
  
  public static string ParseRem(int rem)
  {
      string str = "";
      switch(rem)
      {
         case 10:
            str = "A";
            break;
         case 11:
            str = "B";
            break;
         case 12:
            str = "C";
            break;
         case 13:
            str = "D";
            break;
         case 14:
            str = "E";
            break;
         case 15:
            str = "F";
            break;
         default:
            str = "Invalid";
            break;
      }
        return str;
  }
}