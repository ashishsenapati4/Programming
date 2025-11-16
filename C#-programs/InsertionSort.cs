//insertion sort implementation
//considers 1st element as sorted array, compares current element with the elements in sorted array portion and inserts it in the correct place
using System;
class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr= {72,23,45,6,98,89,45,12,90,88,56,6};
        int[] newArr = InsertionSort(arr,0,arr.Length-1);
        foreach(int i in newArr)
        {
            Console.Write(i+" ");
        }
    }
    
    public static int[] InsertionSort(int[] arr,int low,int high)
    {
       for(int i=low;i<=high;i++)
       {
           int j = i;
           while(j > 0 && arr[j-1] > arr[j])
           {
               int temp = arr[j-1];
               arr[j-1] = arr[j];
               arr[j] = temp;
               j--;
           }
       }
       return arr;
    }
    
}