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

// Javier Cases Sempere

using System;

struct Contabilidad
{
    public string fecha;
    public string descripcion;
    public string categoria;
    public double importe;
}

public class Ex188
{
    public static void Main()
    {
        const short SIZE = 10000;
        Contabilidad[] cuentas = new Contabilidad[SIZE];
        bool salir = false;
        string opcion;
        int count = 0;


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
                case "1":
                    if (count < SIZE)
                    {
                        Console.Write("Fecha: ");
                        cuentas[count].fecha = Console.ReadLine();

                        do
                        {
                            Console.Write("Descripcion: ");
                            cuentas[count].descripcion = Console.ReadLine();
                            if (cuentas[count].descripcion == "")
                                Console.WriteLine(
                                    "¡La descripción no puede estar vacio!");
                        }
                        while (cuentas[count].descripcion == "");

                        Console.Write("Categoría: ");
                        cuentas[count].categoria = Console.ReadLine();

                        Console.Write("Importe: ");
                        cuentas[count].importe = Convert.ToDouble(Console.ReadLine());

                        count++;
                    }
                    else
                        Console.WriteLine("¡No hay más espacio!");
                    break;

                case "2":
                    Console.Write("Introduce el término a buscar por categoría: ");
                    string textoCat = Console.ReadLine().ToLower();

                    Console.Write("Entre la fecha: ");
                    string fechaA = Console.ReadLine();
                    Console.Write("Y la fecha: ");
                    string fechaB = Console.ReadLine();


                    for (int i = 0; i < count; i++)
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

                case "3":

                    Console.Write(
                        "Introduce el término a buscar por categoría o descripción: ");
                    string textoCatDes = Console.ReadLine().ToLower();

                    for (int i = 0; i < count; i++)
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

                case "4":

                    Console.Write("Introduce el número de la ficha a modificar: ");
                    short fichaMod = fichaMod = Convert.ToInt16(Console.ReadLine());
                    fichaMod--;
                    aceptado = fichaMod < count || fichaMod > 0;

                    if (aceptado)
                    {
                        Console.WriteLine("Para no modificar, no introducir nada: ");

                        Console.Write("Fecha... (Actual: " + cuentas[fichaMod].fecha+ ") ");
                        string fecha = Console.ReadLine();
                        if (fecha == "")
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].fecha);
                        else
                        {
                            cuentas[fichaMod].fecha = fecha;
                            Console.WriteLine("Cambia su valor a: " + fecha);
                        }


                        Console.Write("Descripcion... (Actual: "
                            + cuentas[fichaMod].descripcion + ") ");
                        string descripcion = Console.ReadLine();
                        if (descripcion == "")
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].descripcion);
                        else
                        {
                            cuentas[fichaMod].descripcion = descripcion;
                            Console.WriteLine("Cambia su valor a: " + descripcion);
                        }

                        Console.Write("Categoría... (Actual: "
                            + cuentas[fichaMod].categoria + ") ");
                        string categoria = Console.ReadLine();
                        if (categoria == "")
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].categoria);
                        else
                        {
                            cuentas[fichaMod].categoria = categoria;
                            Console.WriteLine("Cambia su valor a: " + categoria);
                        }

                        Console.Write("Importe... (Actual: "
                            + cuentas[fichaMod].importe + ") ");
                        string importe = Console.ReadLine();
                        if (importe == "")
                            Console.WriteLine("Se queda con el valor anterior: "
                                + cuentas[fichaMod].importe);
                        else
                        {
                            cuentas[fichaMod].importe = Convert.ToDouble(importe);
                            Console.WriteLine("Cambia su valor a: " + importe);
                        }
                    }
                    else
                        Console.WriteLine("No existe esa ficha.");

                    

                    break;

                case "5":

                    Console.Write("Introduce el número de la ficha a borrar: ");
                    short fichaDel = Convert.ToInt16(Console.ReadLine());
                    fichaDel--;
                    aceptado = fichaDel < count || fichaDel > 0;

                    if (aceptado)
                    {
                        for (int i = fichaDel; i < count; i++)
                            cuentas[i] = cuentas[i + 1];
                        count--;
                        Console.WriteLine("¡Archivo Borrado!");
                    }
                    else
                        Console.WriteLine("No existe esa ficha.");

                    break;

                case "6":
                    for (int i = 0; i < count - 1; i++)
                        for (int j = 1; j < count; j++)
                            if (cuentas[i].fecha.CompareTo(cuentas[j].fecha) > 0)
                            { 
                                Contabilidad aux = cuentas[i];
                                cuentas[i] = cuentas[j];
                                cuentas[j] = aux;
                            }
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
