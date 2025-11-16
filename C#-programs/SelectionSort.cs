//selection sort implementation
//Finds the smallest element from the current array and swaps it with the 1st element of the array. Then reduce the array size by 1
// by ignoring the 1st index. Then again the process repeats.
using System;
class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr= {72,23,45,6,98,89,45,12,90,88,56,6};
        int[] newArr = SelectionSort(arr,0,arr.Length-1);
        foreach(int i in newArr)
        {
            Console.Write(i+" ");
        }
    }
    
    public static int[] SelectionSort(int[] arr,int low,int high)
    {
        if(low < high)
        {
            for(int i=low;i<high;i++)
             {
                int j = FindSmallest(arr,i,high);
                swap(arr,i,j);
             }
        }
        return arr;
    }
    
    public static int FindSmallest(int[] arr,int start,int end)
    {
        int minIndex = start;
        
        for(int i=start+1;i<=end;i++)
        {
            if(arr[i] < arr[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }
    
    public static void swap(int[] arr,int k,int l)
    {
        int temp = arr[k];
        arr[k] = arr[l];
        arr[l] = temp;
    }
    
}