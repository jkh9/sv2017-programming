/*
Create a class named "PseudoRandom".

In it, create a static method "Get0To999" which will return 
the milliseconds of the current system clock.

Create a "Main" to test it.
*/

using System;

class PseudoRandom
{
    public static int Get0to999()
    {
        return DateTime.Now.Millisecond;
    }
}

// --------------------------------

class PseudoRandomTest
{
    static void Main()
    {
        Console.WriteLine( PseudoRandom.Get0to999() );
    }
}
