//decimal to binary..
using System;
using System.Text;

class HelloWorld {
  static void Main() {
      string binary = ConvertToBinary(17);
      
      StringBuilder revStr = new StringBuilder();
      for(int i=binary.Length-1;i>=0;i--)
      {
          revStr.Append(binary[i]);
      }
      Console.WriteLine(revStr+"");
  }
  
  public static string ConvertToBinary(int num)
  {
      StringBuilder str = new StringBuilder();
      while(num > 0)
      {
        int r = num % 2;
        num /= 2;
        str.Append(r);
      }
      return str.ToString();
  }
}