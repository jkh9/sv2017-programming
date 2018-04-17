// Facturación, clase "ListaDeProductos"

// Versiones:
// V0.05a 15-Abr-2018 
//      Moisés: Creada la clase
//      Nacho: Eliminado namespace

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class ListaDeProductos
{
    public List<Producto> Productos { get; set; }
    public int Count { get; set; }

    public ListaDeProductos()
    {
        Load();
        Count = Productos.Count;
    }

    public void Add(Producto productoToAdd)
    {
        Productos.Add(productoToAdd);
        Count++;
    }

    public Producto Get(int index)
    {
        try
        {
            return Productos[index - 1];
        }
        catch (Exception)
        {
            return null;
        }
    }

    public void Load()
    {
        if (File.Exists("productos.dat"))
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("productos.dat",
                    FileMode.Open);
                Productos = (List<Producto>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Read fail");
            }
        }
        else
        {
            Productos = new List<Producto>();
        }
    }

    public void Save()
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("productos.dat",
                FileMode.Create);
            formatter.Serialize(stream, Productos);
            stream.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Write fail ERROR: "+e.Message);
        }
    }
}

