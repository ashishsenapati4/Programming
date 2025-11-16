//sum of digits of positive integers
//189 = 1 + 8 + 9 = 18

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int k = 567890;
        int res = SumOfDigits(k);
        Console.WriteLine(res);
    }
    
    public static int SumOfDigits(int num)
    {
        int res = 0;
        while(num != 0)
        {
            res = res + num % 10;
            num /= 10;
        }
        return res;
    }
}