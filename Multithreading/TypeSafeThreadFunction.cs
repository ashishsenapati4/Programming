//Making the function thread-safe in c#
using System;
using System.Threading;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        NumberHelper helper = new NumberHelper(7);
        
        ThreadStart obj = new ThreadStart(helper.DisplayNumbers);
        Thread t1 = new Thread(obj);
        t1.Start();
    }
}
public class NumberHelper
{
    int _Number;
    
    public NumberHelper(int num)
    {
        _Number = num;
    }
    
    public void DisplayNumbers()
    {
        for(int i=1;i<=_Number;i++)
        {
            Console.WriteLine(i);
        }
    }
}