
using System;
class HelloWorld {
  static void Main() {
      int[] arr = {54, 22, 99, 1, 85, 30, 47, 6, 12, 78, 41, 63, 19, 72, 3, 56, 88, 25, 37, 91, 14, 68, 49, 8, 33, 75, 5, 29, 61, 94};
      int[] newArr = QuickSort(arr,0,arr.Length-1);
      foreach(int i in newArr)
      {
          Console.Write(i+" ");
      }
  }
  
  public static int[] QuickSort(int[] arr,int low,int high)
  {
      if(low < high)
      {
          int pi = Partition(arr,low,high);
          QuickSort(arr,low,pi-1);
          QuickSort(arr,pi+1,high);
      }
      return arr;
  }
  
  public static int Partition(int[] arr,int low,int high)
  {
    int pivot = arr[high];
    int i = low - 1;
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
  
  public static void swap(int[] arr,int j, int k)
  {
      int temp = arr[j];
      arr[j] = arr[k];
      arr[k] = temp;
  }
}