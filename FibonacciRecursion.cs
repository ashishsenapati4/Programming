using System;
class HelloWorld {
  static void Main() {
      int n =10;
      //print 0,1,
      PrintFibonacci(0,1,n-2); // 0,1,1,2,3,5,8,13...
  }
  
  public static void PrintFibonacci(int curr,int next,int count)
  {
    if(count == 0)
    {
        return;
    }
    int sum = curr + next;
    Console.WriteLine(sum);
    PrintFibonacci(next,sum,count - 1);
  }
}