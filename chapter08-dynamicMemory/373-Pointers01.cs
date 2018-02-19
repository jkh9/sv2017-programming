using System;

public class Pointers01
{
    public unsafe static void Main()
    {
        short a = 5;
        short* b;

        b = &a;

        Console.WriteLine( *b );
        Console.WriteLine( (long) b );
        Console.WriteLine( (long) (&a) );

        *b = 7;
        Console.WriteLine(a);
    }
}
