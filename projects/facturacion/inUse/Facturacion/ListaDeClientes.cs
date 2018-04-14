// Facturación, clase "ListaDeClientes"

// Versiones:
// V0.02a 11-Abr-2018 Raúl Gogna, correcciones por Nacho: Constructor, Add, Get, Count
// V0.03a 12-Abr-2018 Raúl Gogna, correcciones por Nacho: Serializa y deserializa

using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class ListaDeClientes
{
    private List<Cliente> clientes;
    public int Count { get { return clientes.Count; }  }

    public ListaDeClientes()
    {
        clientes = new List<Cliente>();
        Cargar();
    }

    public void Add(Cliente cliente)
    {
        clientes.Add(cliente);
        Guardar();
    }

    public Cliente Get(int n)
    {
        if (n >= clientes.Count || n < 0)
        {
            return null;
        }
        else
        {
            return clientes[n];
        }
    }

    public void Guardar()
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("clientes.dat", FileMode.Create,
                FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, clientes);
            stream.Close();
        }
        catch (Exception e)
        {
            // TO DO: Return error code?
        }
    }

    public void Cargar()
    {
        if (File.Exists("clientes.dat"))
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("clientes.dat", FileMode.Open,
                    FileAccess.Read, FileShare.Read);
                clientes = (List<Cliente>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                // TO DO: Return error code?
            }
        }
    }
}

