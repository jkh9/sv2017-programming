// Facturación, clase "ListaDeFacturas"

// Versiones:
// V0.06a 17-Abr-2018 
//      Moisés: Creada la clase
//      Nacho: Eliminado namespace
// V0.08  20-Abr-2018 Moises Encinas, Raul Gogna, Pedro Coloma, Luis Selles
//          Lista de facturas: Pasar las listas de public a private y añadiendo 
//          los metodos Get / Set para que no sean propiedades.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class ListaDeFacturas
{
    private List<Factura> Facturas;
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

    public Factura Get(int n)
    {
        if (n >= Facturas.Count || n < 0)
        {
            return null;
        }
        else
        {
            //Luis - Se vuelve a restar 1 para sacar el cliente que deseamos.
            return Facturas[n - 1];
        }
    }


    public void Set(int n, Factura c)
    {
        if (n >= Facturas.Count || n < 0)
        {
            return;
        }
        else
        {
            //Luis - Se resta - 1 al numero de facturas, que previamente no se restaba.
            Facturas[n - 1] = c;
            Save();
        }
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
                Console.WriteLine("Read fail ERROR: " + e.Message);
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