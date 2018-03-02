// V0.10 17-Ene-2018, Sabater, Pestana, Saorin, Santana
//          Created class Product
// V0.12 02-Mar-2018 Nacho: The class is now public, removed Save and Load

using System.IO;
using System;

public class Product
{
    protected int code;
    protected string name;
    protected float price;


    public Product(int code, string name, float price)
    {
        this.code = code;
        this.name = name;
        this.price = price;
    }

    public int GetCode()
    {
        return code;
    }

    public string GetName()
    {
        return name;
    }

    public float GetPrice()
    {
        return price;
    }

    public void SetCode(int newcode)
    {
        code = newcode;
    }

    public void SetName(string newname)
    {
        name = newname;
    }

    public void SetPrice(float newprice)
    {
        price = newprice;
    }

}
