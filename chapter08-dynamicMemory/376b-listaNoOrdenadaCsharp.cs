// Lista enlazada (no ordenada) en Csharp

using System;

class Lista
{

    public class Nodo            // Cada nodo de la lista
    {
          public int dato;       // - Un dato (int)
          public Nodo siguiente; // - Y el enlace al siguiente dato
    }

    Nodo raiz = null;

    public Lista(int valor)
    {
        raiz = CrearNodo(valor);
    }
    
    private Nodo CrearNodo(int valor)
    {
        Nodo n = new Nodo();     // Reservo memoria
        n.dato = valor;          // Guardo el valor
        n.siguiente = null;      // Y no hay siguiente
        return n;
    }

    public void Escribir( )   // Escribir, desde la raíz
    {
        Escribir (raiz);
    }

    private void Escribir( Nodo n )  // Escribe desde cierto nodo (recursivo)
    {
        if (n != null) 
        {                               // Si hay datos desde aquí
            Console.Write(n.dato+" ");  //  Escribo el dato del nodo
            Escribir(n.siguiente);      //  Y luego miro el siguiente
        }
    }

    public void Insertar( int valor) 
    {
        Insertar(ref raiz, valor);
    }
        
    private void Insertar( ref Nodo nodoInicial, int valor) 
    {
        Nodo nuevoNodo;  // Variable auxiliar, para reservar
        Nodo actual;     // Otra auxiliar, para recorrer
        
        nuevoNodo = CrearNodo(valor);
        actual = nodoInicial;
        
        if (actual == null)
        {                             // Si no hay lista, hay que crearla
            nodoInicial = nuevoNodo;  // y hay que indicar donde debe comenzar
        }
        else                          // Si ya hay datos,
        {
            while (actual.siguiente != null)
                actual = actual.siguiente;  // Avanzo hasta el final
            actual.siguiente = nuevoNodo;   // Y el nuevo nodo será el final
        }
    }
}


public class PruebaLista
{
    //  Cuerpo del programa
    public static void Main()
    {
        Lista l;           // La lista que crearemos
        l = new Lista(5);  // Crea una lista e introduce un 5
        l.Insertar(3);
        l.Insertar(2);
        l.Insertar(6);
        l.Insertar(1);
        l.Escribir();       // Muestra la lista resultante
    }
}
