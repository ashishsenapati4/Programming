//find all substring for a given string
using System;
using System.Text;

class HelloWorld{
    public static void Main(string[] args)
    {
        FindAllSubstring("excommunicado");
    }
    
    public static void FindAllSubstring(string str)
    {
        for(int i=0;i<str.Length;i++)
        {
            StringBuilder substring = new StringBuilder(str.Length - i);
            for(int j=i;j<str.Length;j++)
            {
                substring.Append(str[j]);
                Console.WriteLine(substring);
            }
        }
        
    }
}
