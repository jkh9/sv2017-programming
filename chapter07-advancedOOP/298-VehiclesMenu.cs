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
        const int SIZE = 100;
        Vehicle[] vehicles = new Vehicle[SIZE];
        char option;
        int amount = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add a car");
            Console.WriteLine("2. Add a truck");
            Console.WriteLine("3. Add a motorbike");
            Console.WriteLine("4. Show all data");
            Console.WriteLine("5. Exit");
            option = Convert.ToChar(Console.ReadLine());
            string brand, model;

            switch (option)
            {
                case '1':
                    // Note: this repetitive fragment should be improved
                    Console.Write("Enter the brand: ");
                    brand = Console.ReadLine();
                    Console.WriteLine("Enter the model: ");
                    model = Console.ReadLine();
                    Car c = new Car();
                    c.SetBrand(brand);
                    c.SetModel(model);
                    vehicles[amount] =c;
                    amount++;
                    break;

                case '2':
                    // Note: this repetitive fragment should be improved
                    Console.Write("Enter the brand: ");
                    brand = Console.ReadLine();
                    Console.WriteLine("Enter the model: ");
                    model = Console.ReadLine();
                    Truck t = new Truck();
                    t.SetBrand(brand);
                    t.SetModel(model);
                    vehicles[amount] = t;
                    amount++;
                    break;

                case '3':
                    // Note: this repetitive fragment should be improved
                    Console.Write("Enter the brand: ");
                    brand = Console.ReadLine();
                    Console.WriteLine("Enter the model: ");
                    model = Console.ReadLine();
                    Motorbike m = new Motorbike();
                    m.SetBrand(brand);
                    m.SetModel(model);
                    vehicles[amount] = m;
                    amount++;
                    break;

                case '4':
                    if (amount > 0)
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            vehicles[i].ShowData();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No vehicles registered");
                    }

                    break;

                case '5':
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
