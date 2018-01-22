/*
Ex.311: Class House

Create a class "House", with an attribute "area", a constructor that sets its 
value and a method "ShowData" to display "I am a house, my area is 200 m2" 
(instead of 200, it will show the real surface). Include getters an setters for 
the area, too.

The "House" will contain a door. Each door will have an attribute "color" (a 
string), and a method "ShowData" which will display "I am a door, my color is 
brown" (or whatever color it really is). Include a getter and a setter. Also, 
create a "GetDoor" in the house.

A "SmallApartment" is a subclass of House, with a preset area of 50 m2.

Also create a class Person, with a name (string). Each person will have a 
house. The method "ShowData" for a person will display his/her name, show the 
data of his/her house and the data of the door of that house.

Write a Main to create a SmallApartment, a person to live in it, and to show 
the data of the person.
*/

//Miguel García Gil

using System;

public class House
{
    public double Area { get; set; }
    public Door MyDoor { get; set; }
    
    public House(double area)
    {
        this.Area = area;
    }
    
    public void ShowData()
    {
        Console.WriteLine("I am a house, my area is "+Area+" m2");
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
        
        miguel.ShowData();
    }
}
