//Thread.Join() example...

using System;
using System.Threading;

class HelloWorld {
  static void Main() {
      Console.WriteLine("Main method execution start");
      Thread t1 = new Thread(Method1);
      Thread t2 = new Thread(Method2);
      Thread t3 = new Thread(Method3);
      
      t1.Start();
      t2.Start();
      t3.Start();
      
      t1.Join(); //Block Main Thread until thread1 completes its execution
      t2.Join(); //Block Main Thread until thread2 completes its execution
      t3.Join(); //Block Main Thread until thread3 completes its execution
      
      Console.WriteLine("Main method execuution ended");

  }
  
  public static void Method1()
  {
      Console.WriteLine("Thread1-Method1 execution start.");
      Thread.Sleep(3000);
      Console.WriteLine("Thread1-Method1 execution ended.");
  }
  public static void Method2()
  {
      Console.WriteLine("Thread2-Method2 execution start.");
      Thread.Sleep(2000);
      Console.WriteLine("Thread2-Method2 execution ended.");
  }
  public static void Method3()
  {
      Console.WriteLine("Thread3-Method3 execution start.");
      Thread.Sleep(1000);
      Console.WriteLine("Thread3-Method3 execution ended.");
  }
}