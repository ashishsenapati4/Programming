//THread creation using Lambda
using System;
using System.Threading;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //THread creation using Lmbda Expression
        Thread obj = new Thread(() =>
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i+"");
            }
        });
        obj.Start();
    }
    
}