//Bubble sort:- compares each element with the next element in the list, if next is greater then it swaps. after 
//1st pass the larges element will be at the end of the list

using System;
class BubbleSort {
  static void Main() {
      int[] arr = {20,40,50,9,23,45};
      int[] sortedArr = SortBubble(arr);
      foreach(int i in sortedArr)
      {
          Console.Write(i+" ");
      }
  }
  
  public static int[] SortBubble(int[] arr)
  {
      for(int i=0;i<arr.Length-1;i++)
      {
          for(int j=i+1;j<arr.Length;j++)
          {
              if(arr[i] > arr[j])
             {
              int temp = arr[i];
              arr[i] = arr[j];
              arr[j] = temp;
             }
          }
      }
      return arr;
  }
}