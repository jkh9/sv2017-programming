/*
Ex.304: Table & CoffeeTable

Create a class named "Table". It must have only one constructor, indicating the 
width and height (in centimeters) of the board. The parameters of the 
constructor will be called as the attributes. It will have a method "ShowData" 
which will write on the screen the width and that height of the table. It will 
have a method ToString, which will return "Table, w=100, h=90" (or the correct 
data for this table).

Also, create a class "CoffeeTable" that inherits from "Table". It must have 
only one constructor, indicating the width and height (in centimeters). Its 
method "ShowData", besides writing the width and height, must display "(Coffee 
table)". Its method ToString, will return "CoffeeTable, w=100, h=90" (or the 
correct data for this table).

Create an array that contains 5 tables and 5 coffee tables (only one array, 
which will contain data of both types). The tables must have random sizes 
between 50 and 200 cm, and the coffee tables from 40 to 120 cm. Show all their 
data two times: first using ShowData and then using ToString.
*/

// Javier Cases Sempere

using System;

public class Table
{
    protected int width, height;

    public Table(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public virtual void ShowData() { Console.WriteLine(this); }

    public override string ToString()
    {
        return "Table, W = " + width + ", H = " + height;
    }

    public void SetWidth(int width) { this.width = width; }
    public void SetHeight(int height) { this.height = height; }
    public int GetWidth() { return width; }
    public int GetHeight() { return height; }
}

// ------------------------------------------------

public class CoffeeTable : Table
{
    public CoffeeTable(int width, int height) : 
        base (width, height) { }

    public override void ShowData() 
    { 
        base.ShowData(); 
        Console.WriteLine(" (CoffeeTable)");
    }

    public override string ToString() 
    { 
        return "Coffee" + base.ToString(); 
    }
}

// ------------------------------------------------

public class Program
{
    public static void Main()
    {
        Table[] table = new Table[10];
        Random r = new Random();

        // Let's add data
        for (int i = 0; i < 5; i++)
            table[i] = new Table( r.Next(50, 201), r.Next(50, 201) );
        for (int i = 5; i < 10; i++)
            table[i] = new CoffeeTable( r.Next(40, 121), r.Next(40, 121));

        // And display them in two different ways
        for (int i = 0; i < 10; i++)
            table[i].ShowData();
        for (int i = 0; i < 10; i++)
            Console.WriteLine(table[i].ToString());
    }
}
