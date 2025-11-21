using System;
class HelloWorld {
  static void Main() {
      int[] arr = {8,4,5,2};
      int[] newAr=MergeSort(arr,0,arr.Length-1);
      foreach(int i in newAr)
      {
          Console.Write(i+" ");
      }
  }
  public static int[] MergeSort(int[] arr,int start, int end)
  {
      if(start < end)
      {
          int mid = (start+end)/2;
          MergeSort(arr,start,mid);
          MergeSort(arr,mid+1,end);
          Merge(arr,start,end);
      }
      return arr;
  }
  public static void Merge(int[] A,int start,int end)
  {
      int[] arr = new int[end-start+1];
      int mid = (start+end)/2;
      int k = 0;
      int p = start,q = mid+1;
      
      for(int i = start;i<=end;i++)
      {
          if(p > mid)
          {
            arr[k++] = A[q++];   
          }
          else if(q > end)
          {
            arr[k++] = A[p++];
          }
          else if(A[p] < A[q])
          {
            arr[k++] = A[p++];
          }
          else
          {
            arr[k++] = A[q++];
          }
      }
      
      for(int i=0;i<k;i++)
      {
          A[start+i] = arr[i];
      }
  }
  
}