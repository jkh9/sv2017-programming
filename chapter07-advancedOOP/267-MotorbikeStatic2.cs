/*
Create a class named “Motorbike”.
It will have an attribute “wheels”, static, with value 2.
Create a method named “GetWheels”, to access that attribute.
Create two motorbikes and display how many wheels they have.
*/

using System;

class Motorbike
{
    protected static int wheels = 2;
    
    public int GetWheels()
    {
        return wheels;
    }
    
    public void SetWheels(int w)
    {
        wheels = w;
    }
}

// --------------------------------

class MotorbikeTest
{
    static void Main()
    {
        Motorbike m1 = new Motorbike();
        Motorbike m2 = new Motorbike();
        
        Console.WriteLine("m1 has {0} wheels", m1.GetWheels() );
        Console.WriteLine("m2 has {0} wheels", m2.GetWheels() );
        
        m1.SetWheels(3);
        
        Console.WriteLine("m1 has {0} wheels", m1.GetWheels() );
        Console.WriteLine("m2 has {0} wheels", m2.GetWheels() );
    }
}
