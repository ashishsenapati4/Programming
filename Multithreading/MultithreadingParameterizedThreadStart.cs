
//THread method execution using ParameterizedThreadStart Delegate

using System;
using System.Threading;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Thread creation using Lmbda Expression
        //here delegate ParameterizedThreadStart will be called. Which takes object as parameter.
        ParameterizedThreadStart obj = new ParameterizedThreadStart(DisplayNumbers);
        Thread t = new Thread(obj);
        t.Start(9);
        
    }
    
    public static void DisplayNumbers(object num)
    {
        int x = Convert.ToInt32(num);
        for(int i=0;i<x;i++)
        {
            Console.WriteLine(i+"");
        }
    }
    
}


//ParameterizedThreadStart Delegate called internally when we pass object as a parameter to the Lambda function
using System;
using System.Threading;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Thread creation using Lmbda Expression
        //here delegate ParameterizedThreadStart will be called. Which takes object as parameter.
        Thread obj = new Thread((object num) =>
        {
            int x = Convert.ToInt32(num);
            for(int i=1;i<=x;i++)
            {
                Console.WriteLine(i+"");
            }
        });
        obj.Start(5);
    }
    
}