//Async / Await example...
using System;
using System.Threading;
using System.Threading.Tasks;


class HelloWorld {
  static void Main() {
      Console.WriteLine("Main method execution started.");
      SomeMethod();
      Console.WriteLine("Main method execution ended");
      Console.ReadKey();
  }
  
  public async static void SomeMethod()
  {
      Console.WriteLine("SomeMethod method execution started.");
      
      await Task.Delay(TimeSpan.FromSeconds(10));
      
      Console.WriteLine("SomeMethod method execution ended.");
  }
}