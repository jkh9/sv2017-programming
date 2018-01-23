/*
Ex.314:
 
Create a new version of the House exercise (312), in which the (only) 
constructor of House will receive three parameters: area, color of the door, 
name of the owner. */

using System;

public class House
{
    public double Area { get; set; }
    public Door MyDoor { get; set; }
    public Person Owner { get; set; }
    
    public House(double area, 
        string doorColor, string ownerName)
    {
        this.Area = area;
        this.MyDoor = new Door(doorColor);
        this.Owner = new Person(ownerName);
    }
    
    public void ShowData()
    {
        Console.WriteLine("I am a house, my area is "+Area+" m2");
    }
    
    public void ShowDetailedData()
    {
        Console.WriteLine("I am a house, my area is "+Area+" m2");
        Console.WriteLine("My owner is "+Owner.Name);
    }
}


public class Door
{
    public string Color { get; set; }
    
    public Door(string color)
    {
        this.Color = color;
    }
    
    public void ShowData()
    {
        Console.WriteLine("I am a door, my color is "+Color);
    }
}


public class SmallApartment : House
{
    public SmallApartment(string doorColor, string ownerName) 
        : base(50, doorColor, ownerName)
    {
    }
}


public class Person
{
    public string Name { get; set; }
    public House MyHouse { get; set; }
    
    public Person(string name)
    {
        this.Name = name;
    }
    
    public void ShowData()
    {
        Console.WriteLine("I am person, my name is "+Name);
        MyHouse.ShowData();
        MyHouse.MyDoor.ShowData();
    }
}


public class HouseDoorAndPersonTest
{
    public static void Main()
    {
        SmallApartment myCasitaInTheMountain = new 
            SmallApartment("Purple", "Miguel");
        
        myCasitaInTheMountain.ShowDetailedData();
    }
}
