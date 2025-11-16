//simple method execution using multithreading

using System;
using System.Threading;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main thread execution start.");
        
        Thread t1 = new Thread(Method1);
        t1.Name = "Thread1";
        t1.Start();
        
        Thread t2 = new Thread(Method2);
        t2.Name = "Thread2";
        t2.Start();
        
        Thread t3 = new Thread(Method3);
        t3.Name = "Thread3";
        t3.Start();
        
        Console.WriteLine("Main thread execution end.");
    }
    
    public static void Method1()
    {
        for(int i=0;i<3;i++)
        {
            Console.WriteLine("Method1 executing."+Thread.CurrentThread.Name);
        }
    }
    public static void Method2()
    {
        for(int i=0;i<3;i++)
        {
            Console.WriteLine("Method2 executing."+Thread.CurrentThread.Name);
        }
    }
    public static void Method3()
    {
        for(int i=0;i<3;i++)
        {
            Console.WriteLine("Method3 executing."+Thread.CurrentThread.Name);
        }
    }
}