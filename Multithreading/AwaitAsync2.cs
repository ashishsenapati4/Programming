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
      
      await Wait(); //if we use await here, then SomeMethod() will wait until completion of Wait().
      
      Console.WriteLine("SomeMethod method execution ended.");
  }
  
  public async static Task Wait()				// use Task return type when you want calling method to wait for this method to complete its execution...
  {
      Console.WriteLine("Wait method called from SomeMethod started.");
      
      await Task.Delay(TimeSpan.FromSeconds(10));
      
      Console.WriteLine("Wait method called from SomeMethod ended.");
  }
}




using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            SomeMethod();

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            Wait();

            Console.WriteLine("Some Method End");
        }

        private static async void Wait()  // use void return type when you want calling method to continue execution without waiting for the called method...
  {
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
    }
}