//Decimal to binary
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string res = ConvertToBinary(16);
        string fRes = Reverse(res);
        
        Console.WriteLine(fRes);
    }
    
    public static string ConvertToBinary(int num)
    {
        string res = "";
        while(num != 0)
        {
            string k = Convert.ToString(num%2);
            res = res+k;
            num = num / 2;
        }
        return res;
    }
    
    public static string Reverse(string res)
    {
        string k = "";
        for(int i=res.Length-1;i>=0;i--)
        {
            k = k+res[i];
        }
        return k;
    }
}