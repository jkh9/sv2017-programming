// Class Car, destructor + 2 constructors

using System;

class Car
{
    protected int wheels;
   
    public Car()
    {
        Console.WriteLine("Creating a car");
        wheels = 4;
    }   
    
    public Car(int newWheels)
    {
        Console.WriteLine("Creating a car with {0} wheels",
            newWheels);
        wheels = newWheels;
    }
    
    public void Display()
    {
        Console.WriteLine("Hi, im a car and i have {0} wheels", 
            wheels);
    }
    
    public void Display(bool showWheels)
    {
        if (showWheels)
            Console.WriteLine("I´m a car and i have {0} wheels", 
                wheels);
        else
            Console.WriteLine("I´m a car");
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
        Car lancia = new Car(6);

        alfa.Display(false);  
        lancia.Display();  
    }
}
