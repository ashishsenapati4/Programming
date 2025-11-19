//Binary search - works on sorted arrays only
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {-9,7,8,9,10,11,12,67,89,99};
        int index = BinarySearch(arr,7);
        Console.WriteLine("Element found at index: "+index);
    }
    public static int BinarySearch(int[] arr,int ele)
    {
          int low = 0;
          int high = arr.Length -1;
          
          while(low <= high)
          {
              int mid = (low+high)/2;
              if(arr[mid] == ele)
              {
                  return mid;
              }
              else if(arr[mid] < ele)
              {
                  low = mid + 1;
              }
              else
              {
                  high = mid - 1;
              }
          }
          return -1;
    }
}