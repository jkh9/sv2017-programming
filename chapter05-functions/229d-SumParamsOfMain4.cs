/*
Params of Main

V 4 : Returning an error code to the Operating System

*/

using System;

public class ParamsOfMain
{
    public static int Main(string[] args)
    {
        if (args.Length != 0)
        {
            int sum = 0;
            foreach(string n in args)
            {
                sum += Convert.ToInt32(n);
            }
            Console.WriteLine(sum);
            return 0;
        }
        else
        {
            Console.WriteLine("Usage: ");
            Console.WriteLine("  sum n1 n2 ...");
            Console.WriteLine("  for example: sum 3 5 26 7)");
            return 1;
        }
    }
}
