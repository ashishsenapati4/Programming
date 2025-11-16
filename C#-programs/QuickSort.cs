//write a c sharp code to implment quick-sort
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {90,34,67,98,39,89};
        //int[] arr = {55,30,20,40,34,67};
        
        int[] sortedArray = QuickSort(arr,0,arr.Length-1);
        foreach(int i in sortedArray)
        {
            Console.Write(i+" ");
        }
    }
    //create quick sort method and call recursively
public static int[] QuickSort(int[] arr,int low,int high)
{
    if(low < high)
    {
        int pi = GetPartitionIndex(arr,low,high);
        Console.WriteLine(pi);
        QuickSort(arr,low,pi-1);
        QuickSort(arr,pi+1,high);
    }
    return arr;
    
}

//create method GetPartitionIndex() which will return the pivot 
//elements position in the partitioned array
public static int GetPartitionIndex(int[] arr,int low,int high)
{
    int pivot = arr[high];
    int i = low-1;
    
        for(int j=low;j<high;j++)
        {
            if(arr[j] < pivot)
            {
                i++;
                swap(arr,i,j);
            }
        }
        swap(arr,i+1,high);
    return i+1;
}

public static void swap(int[] arr,int i,int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
}

