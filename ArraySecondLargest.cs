//Find 2nd largest in array using one loop
//arr = [10,50,89,35,67,56], output:- 67

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {50,23,78,89,45,89};
        int res = FindSecondLargest(arr);
        Console.WriteLine(res);
    }
    
    public static int FindSecondLargest(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        
        foreach(int i in arr)
        {
            if(i > max1)
            {
                max2 = max1;
                max1 = i;
            }
            else if(i >= max2 && i != max1)
            {
                max2 = i;
            }
        }
        return max2;
    }
}

//Using multiple loop
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {50,23,78,89,45,87};
        int whichLargest = 3;
        int res = FindSecondLargest(arr,whichLargest);
        Console.WriteLine(res);
    }
    
    public static int FindSecondLargest(int[] arr,int whichLar)
    {
        int largest=arr[0];
        int selar = 0;
        
        while(whichLar!=0)
        {
            int temp=0;
            largest = 0;
            for(int i=0;i<arr.Length;i++)
            {
            if(arr[i] > largest)
            {
                largest = arr[i];
                temp=i;
            }
            }
            arr[temp] = 0;
            whichLar--;
        }
        return largest;
    }
}