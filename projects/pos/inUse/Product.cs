// V0.10 17-Ene-2018, Sabater, Pestana, Saorin, Santana
//          Created class Product

using System.IO;
using System;

class Product
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

    public static void LoadFromFile(ref int code,
        ref string name,
        ref float price,
        Product[] products,
        ref int amountOfProducts)
    {
        if (File.Exists("products.dat"))
        {
            string[] dataFromFile = File.ReadAllLines("products.dat");
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                products[i].code = Convert.ToInt32(dataFromFile[i].Split('#')[0]);
                products[i].name = dataFromFile[i].Split('#')[1];
                products[i].price = Convert.ToSingle(dataFromFile[i].Split('#')[2]);
            }
            amountOfProducts = dataFromFile.Length;
        }
    }


    public static void SaveToFile(
        int code, string name,
        float price, int amountOfProducts)
    {
        string[] dataToFile = new string[amountOfProducts];

        for (int i = 0; i < amountOfProducts; i++)
        {
            dataToFile[i] = code + "#" + name + "#" + price;
        }
        File.WriteAllLines("products.dat", dataToFile);
    }
}
