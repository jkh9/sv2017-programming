/*
Create only the following range of classes:

Vehicle
--Motorbike
--Car
--Truck

Each class must contain a brand, a model, and a "ShowData" method, which will 
display texts such as "Car - Pontiac - Transam" (category, brand & model)

The user will be shown a menu, in which they will be allowed to enter data 
(into an array of 100 vehicles) and to display all the data stored so far.

V2: Use a constructor to define the brand and model, create a ToString
and avoid repetitive code in Main

*/

using System;

public class Vehicle
{
    protected string brand;
    protected string model;

    public Vehicle(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

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

    public override string ToString()
    {
        return "Undefined vehicle!";
    }

    public virtual void ShowData()
    {
        Console.Write(this);
    }
}

// -------------------------------------------------------------------------

public class Car : Vehicle
{
    public Car(string brand, string model)
        : base(brand, model)
    {
    }

    public override string ToString()
    {
        return "Car - "+ brand +" - " + model;
    }
}

// -------------------------------------------------------------------------

public class Motorbike : Vehicle
{
    public Motorbike(string brand, string model)
        : base(brand, model)
    {
    }

    public override string ToString()
    {
        return "Motorbike - " + brand + " - " + model;
    }
}

// -------------------------------------------------------------------------

public class Truck : Vehicle
{
    public Truck(string brand, string model)
        : base(brand, model)
    {
    }

    public override string ToString()
    {
        return "Truck - " + brand + " - " + model;
    }
}


// -------------------------------------------------------------------------

public class VehiclesTest
{
    public static void Main()
    {
        const int SIZE = 100;
        Vehicle[] vehicles = new Vehicle[SIZE];
        char option;
        int amount = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show all data");
            Console.WriteLine("3. Exit");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    Console.Write("Add a car (C), motorbike (M) or truck (T)? ");
                    string type = Console.ReadLine().ToUpper();
                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Enter the model: ");
                    string model = Console.ReadLine();
                    if (type == "C")
                        vehicles[amount++] = new Car(brand, model);
                    else if (type == "M")
                        vehicles[amount++] = new Motorbike(brand, model);
                    else if (type == "T")
                        vehicles[amount++] = new Truck(brand, model);
                    else
                        Console.WriteLine("Wrong type of vehicle!");
                    break;
                case '2':
                    if (amount > 0)
                        for (int i = 0; i < amount; i++)
                        {
                            vehicles[i].ShowData();
                            Console.WriteLine();
                        }
                    else
                        Console.WriteLine("No vehicles registered");
                    break;

                case '3':
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        while (option != '5');
        Console.WriteLine("Bye!");
    }
}
