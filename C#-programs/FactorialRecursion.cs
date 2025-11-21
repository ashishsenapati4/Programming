//Factorial using recursion
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int res = FindFactorial(15);
        Console.WriteLine(res);
    }
    public static int FindFactorial(int num)
    {
        if(num == 0)
        {
            return 1;
        }
        return num*FindFactorial(num-1);
    }
    
}