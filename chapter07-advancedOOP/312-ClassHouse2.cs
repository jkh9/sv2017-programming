/*
Ex.312:
 
Expand the House exercise (311), with a ShowDetailedData method for the House, 
which will also display the name of its owner.
*/

using System;

public class House
{
    public double Area { get; set; }
    public Door MyDoor { get; set; }
    public Person Owner { get; set; }
    
    public House(double area)
    {
        this.Area = area;
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
    public SmallApartment() : base(50)
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
        SmallApartment myCasitaInTheMountain = new SmallApartment();
        Person miguel = new Person("Miguel");
        Door purpleDoor = new Door("Purple");
        
        miguel.MyHouse = myCasitaInTheMountain;
        miguel.MyHouse.MyDoor = purpleDoor;
        myCasitaInTheMountain.Owner = miguel;
        
        myCasitaInTheMountain.ShowDetailedData();
    }
}
