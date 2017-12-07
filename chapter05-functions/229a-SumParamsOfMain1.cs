/*
Params of Main

V 1 : Too simple, should not be used

*/

using System;

public class ParamsOfMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine( Convert.ToInt32( args[0] ) +
            Convert.ToInt32( args[1] ) );
    }
}
