/*
Params of Main

V 2 : The usual way

*/

using System;

public class ParamsOfMain
{
    public static void Main(string[] args)
    {
        if (args.Length == 2)
        {
            Console.WriteLine( Convert.ToInt32( args[0] ) +
                Convert.ToInt32( args[1] ) );
        }
        else
        {
            Console.WriteLine("Usage: ");
            Console.WriteLine("  sum n1 n2");
            Console.WriteLine("  for example: sum 3 5)");
        }
    }
}
