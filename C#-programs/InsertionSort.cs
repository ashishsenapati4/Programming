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

using System;
class HelloWorld {
  static void Main() {
      int[] arr = {18,9,1,3,2,4,6,12,34};
      int[] ar = InsertionSort(arr);
      foreach(int i in ar)
      {
          Console.Write(i+" ");
      }
  }
  public static int[] InsertionSort(int[] arr)
  {
      int n = arr.Length;
      for(int i=1;i<n;i++)
      {
          int count = i;
          while(count > 0)
          {
              if(arr[count] < arr[count-1])
              {
                  //swap
                  int temp = arr[count];
                  arr[count] = arr[count-1];
                  arr[count-1] = temp;
              }
              count--;
          }
      }
      return arr;
  }
}