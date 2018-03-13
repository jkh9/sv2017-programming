/*
Create a class Item containing two attributes: 
description (string) and price (double)

Include getters and setters

Include also a Save method and a Load method, which
will use a BinaryWriter and a BinaryReader
*/

using System;
using System.IO;

public class Item
{
	protected string description;
	protected double price;
	
	public Item(string description, double price)
	{
		this.description = description;
		this.price = price;
	}
	
	public void SetPrice(double p)
	{
		price = p;
	}
	
	public double GetPrice()
	{
		return price;
	}
	
	public void SetDescription(string d)
	{
		description = d;
	}
	
	public string GetDescription()
	{
		return description;
	}
	
	public void Save()
	{
		BinaryWriter output =
			new BinaryWriter(
				File.Open("item.dat", FileMode.Create));
		output.Write(description);
		output.Write(price);
		output.Close();
	}
	
	public void Load()
	{
		BinaryReader input =
			new BinaryReader(
				File.Open("item.dat", FileMode.Open));
		description = input.ReadString();
		price = input.ReadDouble();
		input.Close();
	}
}	

public class ItemTest
{	
    public static void Main()
    {
        Item i = new Item("test", 10);
        Console.WriteLine(i.GetDescription() + " " +
			i.GetPrice());
		i.Save();
		
		i = new Item("test 2", 20);
        Console.WriteLine(i.GetDescription() + " " +
			i.GetPrice());
		i.Load();
		Console.WriteLine(i.GetDescription() + " " +
			i.GetPrice());
    }
}
