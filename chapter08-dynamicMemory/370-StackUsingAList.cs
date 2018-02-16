// Stack of strings using a List<string>

using System;
using System.Collections.Generic;

public class StackStr
{
    private List<string> data;
    
    public StackStr()
    {
        data = new List<string>();
    }
    
    public void Push(string s)
    {
        data.Add(s);
    }
    
    public string Pop()
    {
        string s = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        return s;
    }
    
    public string Peek()
    {
        return data[data.Count - 1];
    }
    
    public int Count
    {
        get { return data.Count; }
    }
}


public class StackStrTest
{
    public static void Main()
    {
        StackStr myStack = new StackStr();
        
        for (int i = 0; i < 5; i++)
        {
            myStack.Push("Data " + i);
        }
        
        Console.WriteLine(myStack.Peek());
        Console.WriteLine(myStack.Pop());
        Console.WriteLine();
        while (myStack.Count > 0)
            Console.WriteLine(myStack.Pop());
    }
}
