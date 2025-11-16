//Thread Synchronization using lock()...

using System;
using System.Threading;

class HelloWorld {
    
  static object lockObject = new Object();
    
  static void Main() {
      Console.WriteLine("Main method execution start");
      Thread t1 = new Thread(SomeMethod);
      Thread t2 = new Thread(SomeMethod);
      Thread t3 = new Thread(SomeMethod);
      
      t1.Start();
      t2.Start();
      t3.Start();
      
  }
  public static void SomeMethod()
  {
      lock(lockObject)
      {
        Console.Write("[Dot Net is the best ");
        Thread.Sleep(1000);
        Console.WriteLine("framework in the world!]");
      }
  }
}