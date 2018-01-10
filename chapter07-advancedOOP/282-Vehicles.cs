/*
Create only the following range of classes:

Vehicle
--Motorbike
--Car
--Truck

Each class must contain a brand, a model, and a "ShowData" method, which will 
display texts such as "Car - Pontiac - Transam" (category, brand & model)

Create an array containing a motorbike, a car and a truck, and display their 
data.
*/

using System;

public class Vehicle
{
    protected string brand;
    protected string model;

    public void SetBrand(string newBrand)
    {
        brand = newBrand;
    }
    
    public void SetModel(string newModel)
    {
        model = newModel;
    }
    
    public string GetBrand()
    {
        return brand;
    }
    
    public string GetModel()
    {
        return model;
    }
    
    public virtual void ShowData()
    {
        Console.Write("Undefined vehicle!");
    }
}

// -------------------------------------------------------------------------

public class Car : Vehicle
{
    public override void ShowData()
    {
        Console.Write("Car - {0} - {1}", brand, model);
    }
}

// -------------------------------------------------------------------------

public class Motorbike : Vehicle
{
    public override void ShowData()
    {
        Console.Write("Motorbike - {0} - {1}", brand, model);
    }
}

// -------------------------------------------------------------------------

public class Truck : Vehicle
{
    public override void ShowData()
    {
        Console.Write("Truck - {0} - {1}", brand, model);
    }
}


// -------------------------------------------------------------------------

public class VehiclesTest
{
    public static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car();
        vehicles[0].SetBrand("Pontiac");
        vehicles[0].SetModel("Transam");
        vehicles[1] = new Motorbike();
        vehicles[1].SetBrand("Honda");
        vehicles[1].SetModel("VFR");
        vehicles[2] = new Truck();
        vehicles[2].SetBrand("GMC");
        vehicles[2].SetModel("Sierra");
        
        for(int i = 0; i < 3; i++)
        {
            vehicles[i].ShowData(); 
            Console.WriteLine();
        }
    }
}
