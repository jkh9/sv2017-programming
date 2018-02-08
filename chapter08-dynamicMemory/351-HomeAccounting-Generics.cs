/*

Crea un programa en C# que pueda almacenar hasta 10000 gastos e ingresos, para 
crear un pequeño sistema de contabilidad doméstica. Para cada gasto (o 
ingreso), debe permitir guardar los siguientes datos:

- Fecha (8 caracteres: formato AAAAMMDD)
- Descripción del gasto o ingreso
- Categoría
- Importe (positivo si es un ingreso, negativo si es un gasto)

El programa debe permitir al usuario realizar las siguientes operaciones:

1-  Añadir un nuevo gasto (la descripción no debe estar vacía).

2- Mostrar todos los gastos de una cierta categoría (por ejemplo, "estudios") 
entre dos ciertas fechas (por ejemplo entre "20110101" y "20111231").

3- Buscar gastos que contengan un cierto texto (en la descripción o en la 
categoría, sin distinguir mayúsculas ni minúsculas).

4- Modificar una ficha (pedirá el número de ficha al usuario; se mostrará el 
valor anterior de cada campo y se podrá pulsar Intro para no modificar alguno 
de los datos). Se debe avisar (pero no volver a pedir) si el usuario introduce 
un número de ficha incorrecto.

5- Borrar un cierto dato, cuyo número indicará el usuario. Se debe avisar (pero 
no volver a pedir) si introduce un número incorrecto.

6- Ordenar los datos alfabéticamente, según fecha.

T- Terminar el uso de la aplicación (como no sabemos almacenar la información, 
los datos se perderán).

*/

//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;

struct Contabilidad : IComparable
{
    public string fecha;
    public string descripcion;
    public string categoria;
    public double importe;

    public int CompareTo(Object c2)
    {
		string fecha2 = ( (Contabilidad) c2).fecha;
        return fecha.CompareTo(fecha);
    }
}

public class Ex351
{
    public static void Main()
    {
        List<Contabilidad> cuentas = new List<Contabilidad>();
        bool salir = false;
        string opcion;

        do
        {
            Console.WriteLine("1- Añadir Gasto");
            Console.WriteLine("2- Buscar Gasto por Fecha y Categoría");
            Console.WriteLine("3- Buscar Gasto por Text");
            Console.WriteLine("4- Modificar Gasto");
            Console.WriteLine("5- Borrar Gasto");
            Console.WriteLine("6- Ordenar por Fecha");
            Console.WriteLine("T- Salir");

            Console.WriteLine();

            Console.Write("Introduce una Opción: ");
            opcion = Console.ReadLine().ToLower();

            bool aceptado = false;
            bool encontrado = false;

            switch (opcion)
            {
                //Añadir Gasto
                case "1":
                    Contabilidad cuenta = new Contabilidad();

                    Console.Write("Fecha: ");
                    cuenta.fecha = Console.ReadLine();

                    do
                    {
                        Console.Write("Descripcion: ");
                        cuenta.descripcion = Console.ReadLine();
                        if (cuenta.descripcion == "")
                            Console.WriteLine(
                                "¡La descripción no puede estar vacio!");
                    }
                    while (cuenta.descripcion == "");

                    Console.Write("Categoría: ");
                    cuenta.categoria = Console.ReadLine();

                    Console.Write("Importe: ");
                    cuenta.importe = Convert.ToDouble(Console.ReadLine());

                    cuentas.Add(cuenta);
                    break;
                //Buscar Gasto por Fecha y Categoría
                case "2":
                    Console.Write("Introduce el término a buscar por categoría: ");
                    string textoCat = Console.ReadLine().ToLower();

                    Console.Write("Entre la fecha: ");
                    string fechaA = Console.ReadLine();
                    Console.Write("Y la fecha: ");
                    string fechaB = Console.ReadLine();


                    for (int i = 0; i < cuentas.Count; i++)
                        if (cuentas[i].categoria.ToLower().Contains(textoCat)
                            && (cuentas[i].fecha.CompareTo(fechaA) > 0
                            && cuentas[i].fecha.CompareTo(fechaB) < 0))
                        {
                            encontrado = true;
                            Console.WriteLine("Resultados:");
                            Console.WriteLine("Fecha: " + cuentas[i].fecha);
                            Console.WriteLine("Descripción: "
                                + cuentas[i].descripcion);
                            Console.WriteLine("Categoría: "
                                + cuentas[i].categoria);
                            Console.WriteLine("Importe: " + cuentas[i].importe);
                        }

                    if (!encontrado)
                        Console.WriteLine("Ningun resultado encontrado.");
                    break;

                //Buscar Gasto por Text
                case "3":

                    Console.Write(
                        "Introduce el término a buscar por categoría o descripción: ");
                    string textoCatDes = Console.ReadLine().ToLower();

                    for (int i = 0; i < cuentas.Count; i++)
                        if (cuentas[i].categoria.ToLower().Contains(textoCatDes)
                            || cuentas[i].descripcion.ToLower().Contains(textoCatDes))
                        {
                            encontrado = true;
                            Console.WriteLine("Resultados:");
                            Console.WriteLine("Fecha: " + cuentas[i].fecha);
                            Console.WriteLine("Descripción: " + cuentas[i].descripcion);
                            Console.WriteLine("Categoría: " + cuentas[i].categoria);
                            Console.WriteLine("Importe: " + cuentas[i].importe);
                        }

                    if (!encontrado)
                        Console.WriteLine("Ningun resultado encontrado.");

                    break;

                //Modificar Gasto
                case "4":

                    Console.Write("Introduce el número de la ficha a modificar: ");
                    short fichaMod = fichaMod = Convert.ToInt16(Console.ReadLine());
                    fichaMod--;
                    aceptado = fichaMod < cuentas.Count || fichaMod > 0;

                    if (aceptado)
                    {
                        Contabilidad contabilidad = new Contabilidad();
                        Console.WriteLine("Para no modificar, no introducir nada: ");

                        Console.Write("Fecha... (Actual: " + cuentas[fichaMod].fecha + ") ");
                        string fecha = Console.ReadLine();
                        if (fecha == "")
                        {
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].fecha);
                            contabilidad.fecha = cuentas[fichaMod].fecha;
                        }

                        else
                        {
                            contabilidad.fecha = fecha;
                            Console.WriteLine("Cambia su valor a: " + fecha);
                        }


                        Console.Write("Descripcion... (Actual: "
                            + cuentas[fichaMod].descripcion + ") ");
                        string descripcion = Console.ReadLine();
                        if (descripcion == "")
                        {
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].descripcion);
                            contabilidad.descripcion = cuentas[fichaMod].descripcion;
                        }

                        else
                        {
                            contabilidad.descripcion = descripcion;
                            Console.WriteLine("Cambia su valor a: " + descripcion);
                        }

                        Console.Write("Categoría... (Actual: "
                            + cuentas[fichaMod].categoria + ") ");
                        string categoria = Console.ReadLine();
                        if (categoria == "")
                        {
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].categoria);
                            contabilidad.categoria = cuentas[fichaMod].categoria;
                        }

                        else
                        {
                            contabilidad.categoria = categoria;
                            Console.WriteLine("Cambia su valor a: " + categoria);
                        }

                        Console.Write("Importe... (Actual: "
                            + cuentas[fichaMod].importe + ") ");
                        string importe = Console.ReadLine();
                        if (importe == "")
                        {
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].importe);
                            contabilidad.importe = cuentas[fichaMod].importe;
                        }
                        else
                        {
                            contabilidad.importe = Convert.ToDouble(importe);
                            Console.WriteLine("Cambia su valor a: " + importe);
                        }
                        cuentas[fichaMod] = contabilidad;
                    }
                    else
                        Console.WriteLine("No existe esa ficha.");
                    break;

                //Borrar Gasto
                case "5":

                    Console.Write("Introduce el número de la ficha a borrar: ");
                    short fichaDel = Convert.ToInt16(Console.ReadLine());
                    fichaDel--;
                    aceptado = fichaDel < cuentas.Count || fichaDel > 0;

                    if (aceptado)
                    {
                        cuentas.RemoveAt(fichaDel);
                        Console.WriteLine("¡Archivo Borrado!");
                    }
                    else
                        Console.WriteLine("No existe esa ficha.");

                    break;

                //Ordenar por Fecha
                case "6":
                    cuentas.Sort();
                    Console.WriteLine("¡Archivos Ordenados!");
                    break;

                case "t":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }
            Console.WriteLine();
        }
        while (!salir);
        Console.WriteLine("¡Adiós!");
    }
}
