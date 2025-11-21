//Sum of Digits
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int res = SumOfDigits(897);
        Console.WriteLine(res);
    }
    public static int SumOfDigits(int num)
    {
        if(num == 0)
        {
            return 0;
        }
        int k = num%10;
        num=num/10;
        return k+SumOfDigits(num);
    }
    
}