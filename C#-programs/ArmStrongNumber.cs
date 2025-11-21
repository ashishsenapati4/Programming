//Armstrong number
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool res = IsArmStrong(407);
        Console.WriteLine(res);
    }
    
    public static bool IsArmStrong(int num)
    {
        int k = CalculateDigits(num);
        Console.WriteLine(k+"");
        int temp = num;
        int res = 0;
        while(temp!=0)
        {
            int f = (temp%10);
            res = res + Convert.ToInt32(Math.Pow(f,k));
            temp = temp/10;
        }
        Console.WriteLine(res);
        if(num == res)
        {
            return true;
        }
        return false;
    }
    public static int CalculateDigits(int num)
    {
        int count = 0;
        while(num!=0)
        {
            num = num/10;
            count++;
        }
        return count;
    }
}