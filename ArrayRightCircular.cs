10 20 30 40 50
50 10 20 30 40
40 50 10 20 30
30 40 50 10 20
20 30 40 50 10

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {10,20,30,40,50};
        
        //iterate from first and swap each element with the last
            for(int i=0;i<arr.Length;i++)
            {
                int temp = arr[arr.Length-1];
                arr[arr.Length-1]=arr[i];
                arr[i]=temp;
            }
    
        foreach(int i in arr)
        {
            Console.Write(" "+i);
        }
    }
}