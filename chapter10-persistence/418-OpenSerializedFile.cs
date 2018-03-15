/*
Create a new version of the class Item, using serialization

(Use a different file name: formats will not be the same)
*/

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
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
    
    public static void Save(Item i) {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("item2.dat",
            FileMode.Create, FileAccess.Write, 
            FileShare.None);
        formatter.Serialize(stream, i);
        stream.Close();
    }
    
    public static Item Load() 
    {
        Item i;
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("item2.dat", 
            FileMode.Open, FileAccess.Read, 
            FileShare.Read);
        i = (Item) formatter.Deserialize(stream);
        stream.Close();
        return i;
    }
    
}   

public class OpenSerializedFile
{   
    public static void Main()
    {
        Item i = Item.Load();
        Console.WriteLine(i.GetDescription() + " " +
            i.GetPrice());
    }
}
