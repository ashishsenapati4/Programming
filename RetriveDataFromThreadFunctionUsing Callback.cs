//We can define a callback function as a function pointer that is being passed as an argument to another function. And then it is expected to call back that function at some point in time.

// In our example, we call the thread function of NumberHelper class from the Main method of the Program class. While creating the instance of NumberHelper class we pass the callback function as an argument to that class constructor. And then we expected that callback method to be called at some point in time by the NumberHelper method.
using System;
using System.Threading;

public delegate void ResultCallbackDelegate(int result);
public class HelloWorld
{
    public static void Main(string[] args)
    {
        ResultCallbackDelegate resCallBackDel = new ResultCallbackDelegate(PrintResult);
        SumCalculator obj = new SumCalculator(4,resCallBackDel);
        ThreadStart ts = new ThreadStart(obj.CalculateSum);
        Thread t1 = new Thread(ts);
        t1.Start();
    }
    
    public static void PrintResult(int result)
    {
        Console.WriteLine("Sum is: "+result);
    }
}
public class SumCalculator
{
    int _Number;
    ResultCallbackDelegate _requestCallback;
    
    public SumCalculator(int num, ResultCallbackDelegate del)
    {
        _Number = num;
        _requestCallback = del;
    }
    
    public void CalculateSum()
    {
        int Result=0;
        for(int i=1;i<=_Number;i++)
        {
            Result = Result+i;
        }
        if(_requestCallback != null)
        {
            _requestCallback(Result);
        }
    }
}