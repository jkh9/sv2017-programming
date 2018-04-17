using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class ListaDeFacturas
{
    public List<Factura> Facturas { get; set; }
    public int Count { get; set; }

    public ListaDeFacturas()
    {
        Load();
        Count = Facturas.Count;
    }

    public void Add(Factura facturaToAdd)
    {
        Facturas.Add(facturaToAdd);
        Count++;
    }

    public Factura Get(int index)
    {
        return Facturas[index - 1];
    }

    public void Load()
    {
        if (File.Exists("facturas.dat"))
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("facturas.dat",
                    FileMode.Open);
                Facturas = (List<Factura>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Read fail ERROR: "+e.Message);
                Console.ReadLine();
            }
        }
        else
        {
            Facturas = new List<Factura>();
        }
    }

    public void Save()
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("facturas.dat",
                FileMode.Create);
            formatter.Serialize(stream, Facturas);
            stream.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Write fail");
        }
    }
}
