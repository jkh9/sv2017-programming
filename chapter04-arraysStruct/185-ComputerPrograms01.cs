/*
Crea un programa en C# que pueda almacenar fichas de hasta 1000 programas de 
ordenador. Para cada programa, debe guardar los siguientes datos:

Nombre
Categoría
Descripción
Versión (es un conjunto de 3 datos: el número de versión –texto-, el mes de 
  lanzamiento –byte- y el año de lanzamiento –entero corto sin signo-)

El programa debe permitir al usuario las siguientes operaciones:

1- Añadir datos de un nuevo programa (el nombre no debe estar vacío). 

2- Mostrar los nombres de todos las programas almacenados. Cada nombre debe 
aparecer en una línea. Si hay más de 20 programas, se deberá hacer una pausa 
tras mostrar cada bloque de 20 programas, y esperar a que el usuario pulse 
Intro antes de seguir. Se deberá avisar si no hay datos.

3- Ver todos los datos de un cierto programa (a partir de parte su nombre, 
categoría o descripción, sin distinguir mayúsculas ni minúsculas). Se deberá 
avisar si no se encuentra ningún programa.

4- Modificar una ficha (pedirá el número; se mostrará el valor anterior de cada 
campo y se podrá pulsar Intro para no modificar alguno de los datos). Se debe 
avisar (pero no volver a pedir) si introduce un número de ficha incorrecto.

5- Borrar un cierto dato, a partir del número que indique el usuario. Se debe 
avisar (pero no volver a pedir) si introduce un número incorrecto.

6- Ordenar los datos alfabéticamente, según su nombre.

T- Terminar el uso de la aplicación (como no sabemos almacenar la información, 
los datos se perderán).
*/

//Victor Tebar

using System;

struct versionType
{
    public string num;
    public byte month;
    public ushort year;
}

struct programType
{
    public string name;
    public string category;
    public string description;
    public versionType version;
}

public class Ejer185
{
    public static void Main()
    {
        const int MAX_PROGRAMS = 1000;

        programType[] programs = new programType[MAX_PROGRAMS];
        int count = 0;
        string option;

        do
        {
            Console.WriteLine("1.Add program");
            Console.WriteLine("2.Show program's names");
            Console.WriteLine("3.Search programs");
            Console.WriteLine("4.Modify a program");
            Console.WriteLine("5.Delete program");
            Console.WriteLine("6.Order by name");
            Console.WriteLine("T.Exit");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":  // Add
                    if (count < MAX_PROGRAMS)
                    {
                        do
                        {
                            Console.WriteLine
                                ("Program number {0}", count + 1);
                            Console.Write("Enter the name: ");

                            programs[count].name = Console.ReadLine();
                        }
                        while (programs[count].name == "");

                        Console.Write("Enter the category: ");
                        programs[count].category = Console.ReadLine();

                        Console.Write("Enter the description: ");
                        programs[count].description = Console.ReadLine();

                        Console.Write ("Enter the number of the version: ");
                        programs[count].version.num = Console.ReadLine();

                        Console.Write("Enter the release month: ");
                        programs[count].version.month
                            = Convert.ToByte(Console.ReadLine());

                        Console.Write("Enter the release year: ");
                        programs[count].version.year
                            = Convert.ToUInt16(Console.ReadLine());

                        count++;
                    }
                    else
                        Console.WriteLine("The database is full.");
                    break;

                case "2":  // Show all
                    if (count == 0)
                        Console.WriteLine("No programs found");
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Program {0} name:{1}", i + 1,
                                programs[i].name);
                            if (i % 20 == 19)
                                Console.ReadLine();
                        }
                    }
                    break;

                case "3":  // Search
                    bool programsFound = false;

                    Console.Write("Enter the keywords: ");
                    string str = Console.ReadLine().ToLower();

                    for (int i = 0; i < count; i++)
                    {
                        if (programs[i].name.ToLower().Contains(str) ||
                        programs[i].description.ToLower().Contains(str) ||
                        programs[i].category.ToLower().Contains(str))
                        {
                            programsFound = true;

                            Console.WriteLine("Program number {0}", i + 1);
                            Console.WriteLine("Name: {0}", programs[i].name);
                            Console.WriteLine
                                ("Category: {0}", programs[i].category);
                            Console.WriteLine
                                ("Decription: {0}", programs[i].description);
                            Console.WriteLine("Version num: {0}",
                                programs[i].version.num);
                            Console.WriteLine("Release Month: {0}",
                                programs[i].version.month);
                            Console.WriteLine("Release Year: {0}",
                                programs[i].version.year);
                        }
                    }

                    if (!programsFound)
                        Console.WriteLine("No programs found");

                    break;

                case "4":   // Edit
                    int num;

                    Console.Write("Enter the number of the program: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    num--;

                    if (num >= count)
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    else
                    {
                        Console.WriteLine("Program number {0}", num + 1);
                        Console.Write("Enter the new name: ");
                        string answer = Console.ReadLine();
                        if (answer != "")
                            programs[num].name = answer;

                        Console.Write("Enter the new category (it was {0}): ",
                            programs[num].category);
                        answer = Console.ReadLine();
                        if (answer != "")
                            programs[num].category = answer;

                        Console.Write("Enter the new description: ");
                        answer = Console.ReadLine();
                        if (answer != "")
                            programs[num].description= answer;

                        Console.Write("Enter the new number of the version: ");
                        answer = Console.ReadLine();
                        if (answer != "")
                            programs[num].version.num = answer;

                        Console.Write("Enter the new release month: ");
                        answer = Console.ReadLine();
                        if (answer != "")
                            programs[count].version.month = 
                                Convert.ToByte(answer);

                        Console.Write("Enter the new release year: ");
                        answer = Console.ReadLine();
                        if (answer != "")
                            programs[count].version.year = 
                                Convert.ToUInt16(answer);
                    }

                    break;

                case "5":   // Delete a program
                    int pos;

                    Console.Write("Enter the number of the program: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    pos--;

                    if (pos >= count)
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    else
                    {
                        for (int i = pos; i < count - 1; i++)
                        {
                            programs[i] = programs[i + 1];
                        }
                        count--;
                    }
                    break;

                case "6":  // Sort
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            if (String.Compare(programs[i].name, 
                                programs[j].name, true) > 0)
                            {
                                programType aux = programs[i];
                                programs[i] = programs[j];
                                programs[j] = aux;
                            }
                        }
                    }
                    break;

                default: 
                    Console.WriteLine("Unknown option."); 
                    break;
            }
        } 
        while (option != "t");
    }
}

