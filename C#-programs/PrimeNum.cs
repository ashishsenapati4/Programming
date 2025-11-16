//Find if a number is prime or not
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int k = 53;
        bool res = IsPrime(k);
        Console.WriteLine(res ? k+" Is Prime" : k+" Is not prime");
    }
    
    public static bool IsPrime(int num)
    {
        //if a number is divisible by 1 and itself is called prime.
        int count = 0;
        for(int i=2;i<=num/2;i++)
        {
            if(num % i == 0)
            {
                count++;
            }
        }
        if(count == 0)
        {
            return true;
        }
        return false;
    }
}