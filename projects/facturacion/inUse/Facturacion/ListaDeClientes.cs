// Facturación, clase "ListaDeClientes"

// Versiones:
// V0.02a 11-Abr-2018 Raúl Gogna, correcciones por Nacho: Constructor, Add, Get, Count

using System.Collections.Generic;

class ListaDeClientes
{
    private List<Cliente> clientes;
    public int Count { get { return clientes.Count; }  }

    public ListaDeClientes()
    {
        clientes = new List<Cliente>();
    }

    public void Add(Cliente cliente)
    {
        clientes.Add(cliente);
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
}

