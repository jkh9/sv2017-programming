/*
Create a class named "PseudoRandom". (v2: non-static)

In it, create a non-static method "Get0To999" which will return 
the milliseconds of the current system clock.

Create a "Main" to test it.
*/

using System;

class PseudoRandom
{
    public int Get0to999()
    {
        return DateTime.Now.Millisecond;
    }
}

// --------------------------------

class PseudoRandomTest
{
    static void Main()
    {
        PseudoRandom n = new PseudoRandom();
        Console.WriteLine( n.Get0to999() );
    }
}
