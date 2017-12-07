/*
Params of Main

V 3 : For an undetermined amount of parameters
 
*/

using System;

public class ParamsOfMain
{
    public static void Main(string[] args)
    {
        if (args.Length != 0)
        {
            int sum = 0;
            foreach(string n in args)
            {
                sum += Convert.ToInt32(n);
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Usage: ");
            Console.WriteLine("  sum n1 n2 ...");
            Console.WriteLine("  for example: sum 3 5 26 7)");
        }
    }
}
