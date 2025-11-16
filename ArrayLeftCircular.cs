// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {10,20,30,40,50};
        
        //iterate from last and swap each element with the 1st
        int f = 2;
        while(f>0)
        {
            for(int i=arr.Length-1;i>=0;i--)
            {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            }
            f--;
        }
        foreach(int i in arr)
        {
            Console.Write(" "+i);
        }
    }
}