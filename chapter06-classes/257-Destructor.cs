// Class Car, destructor
// Jose Vilaplana

using System;

class Car
{
    protected int wheels;
   
    public Car()
    {
        Console.WriteLine("Creating a car");
        wheels = 4;
    }   
    
    public void Display()
    {
        Console.WriteLine("Hi, im a car and i have {0} wheels", 
            wheels);
    }
    
    ~Car()
    {
        Console.WriteLine("Destroying a car");
    }
}

class Ex257
{
    public static void Main()
    {
        Car alfa = new Car();
        alfa.Display();  
    }
}
