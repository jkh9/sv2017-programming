//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Program
{
    public static void Main()
    {
        Agenda agenda = new Agenda();
        agenda.Deserialize();

        bool exit = false;

        do
        {
            Console.WriteLine("1.- Add person");
            Console.WriteLine("2.- Show people");
            Console.WriteLine("3.- Show people one by one");
            Console.WriteLine("4.- Search");
            Console.WriteLine("5.- Sort");
            Console.WriteLine("6.- Modify");
            Console.WriteLine("0.- Exit");
            string option = Console.ReadLine();
            Console.Clear();
            switch (option)
            {
                case "1": agenda.AddPerson(); break;
                case "2": agenda.ShowPeople() ; Console.ReadLine(); break;
                case "3": agenda.ShowPerson(); break;
                case "4": agenda.Search(); Console.ReadLine(); break;
                case "5": agenda.Sort(); break;
                case "6": agenda.Modify(); break;
                case "0": exit = true; break;
                default: Console.WriteLine("Invalid option"); break;
            }
            Console.Clear();
            agenda.Serialize();
        } while (!exit);
        agenda.Serialize();
    }
}

public class Agenda
{

    public List<Persona> Personas { get; set; }

    public Agenda()
    {
        Personas = new List<Persona>();
    }

    public void AddPerson()
    {
        Persona personaToAdd = new Persona();

        Console.WriteLine("Name");
        personaToAdd.Name = Console.ReadLine();

        Console.WriteLine("Phone");
        personaToAdd.Phone = Console.ReadLine();

        Console.WriteLine("Address1");
        personaToAdd.Address1 = Console.ReadLine();

        Console.WriteLine("Address2");
        personaToAdd.Address2 = Console.ReadLine();

        Console.WriteLine("Observations");
        personaToAdd.Observations = Console.ReadLine();

        Personas.Add(personaToAdd);
    }

    public void Serialize()
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("personas.dat",
                FileMode.Create, FileAccess.Write,
                FileShare.None);
            formatter.Serialize(stream, Personas);
            stream.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Write fail"+e.Message);
        }
    }

    public void Deserialize()
    {
        if (File.Exists("personas.dat"))
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("personas.dat",
                    FileMode.Open, FileAccess.Read,
                    FileShare.Read);
                Personas = (List<Persona>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Read fail" + e.Message);
            }
        }
    }

    public void ShowPeople()
    {
        if (Personas.Count == 0)
        {
            Console.WriteLine("Not data");
        }
        else
        {
            for (int i = 0; i < Personas.Count; i++)
            {
                Console.WriteLine(Personas[i].Name);
                Console.WriteLine(Personas[i].Address1);
                Console.WriteLine(Personas[i].Address2);
                Console.WriteLine(Personas[i].Phone);
                Console.WriteLine(Personas[i].Observations);

                Console.WriteLine();
                if (i % 24 == 23)
                {
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
            }
        }
        Console.WriteLine("Press Enter to continue");
    }

    public void ShowPerson()
    {
        
        int cont = 0;
        bool exit = false;
        do
        {
            Console.Clear();
            DrawTop(cont);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nombre: ");
            Console.ResetColor();
            Console.Write("  ");
            Console.WriteLine(Personas[cont].Name);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Direccion: ");
            Console.ResetColor();
            Console.Write("  ");
            Console.WriteLine(Personas[cont].Address1);
            Console.Write("  ");
            Console.WriteLine(Personas[cont].Address2);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Telefono: ");
            Console.ResetColor();
            Console.Write("  ");
            Console.WriteLine(Personas[cont].Phone);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Observaciones: ");
            Console.ResetColor();
            Console.Write("  ");
            Console.WriteLine(Personas[cont].Observations);

            DrawBottom();

            Console.SetCursorPosition(0, Console.WindowHeight);
            string line = Console.ReadLine();

            switch (line)
            {
                case "1":
                    if (cont > 0)
                    {
                        cont--;
                    }
                    break;
                case "2":
                    if (cont < Personas.Count - 1)
                    {
                        cont++;
                    }
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    break;
            }
        } while (!exit);
    }

    public void Search()
    {
        bool datafound = false;
        Console.Write("Text to search? ");
        string str = Console.ReadLine().ToLower();
        for (int i = 0; i < Personas.Count; i++)
        {
            if (Personas[i].Name.ToLower().Contains(str) ||
                Personas[i].Address1.ToLower().Contains(str) ||
                Personas[i].Address2.ToLower().Contains(str) ||
                Personas[i].Phone.ToString().Contains(str) ||
                Personas[i].Observations.ToString().Contains(str))
            {
                datafound = true;
                Console.WriteLine("Nombre {0}", i + 1);
                Console.WriteLine("Direccion 1: {0}", Personas[i].Address1);
                Console.WriteLine("Direccion 2: {0}", Personas[i].Address2);
                Console.WriteLine("Telefono: {0}", Personas[i].Phone);
                Console.WriteLine("Observaciones: {0}", Personas[i].Observations);
                Console.WriteLine();
            }
        }
        if (!datafound)
            Console.WriteLine("Data not found");
    }

    public void Sort()
    {
        Personas.Sort();
    }

    public void Modify()
    {
        Console.Write("Number of record to modify? ");
        int num = Convert.ToInt32(Console.ReadLine()) - 1;
        if (num >= Personas.Count || num < 0)
            Console.WriteLine("Not a valid record number");
        else
        {
            Persona personToModify = Personas[num];
            Console.WriteLine("Nombre {0}", num + 1);
            Console.WriteLine("Enter the new nombre (it was {0})",
                Personas[num].Name);
            string answer = Console.ReadLine();
            if (answer != "")
                personToModify.Name = answer;

            Console.WriteLine("Enter the new direccion 1 (it was {0})",
                Personas[num].Address1);
            answer = Console.ReadLine();
            if (answer != "")
                personToModify.Address1 = answer;

            Console.WriteLine("Enter the new direccion 2 (it was {0})",
                Personas[num].Address2);
            answer = Console.ReadLine();
            if (answer != "")
                personToModify.Address2 = answer;

            Console.WriteLine("Enter the new telefono (it was {0})",
                Personas[num].Phone);
            answer = Console.ReadLine();
            if (answer != "")
                personToModify.Phone = answer;

            Console.WriteLine("Enter the new observaciones (it was {0})",
                Personas[num].Observations);
            answer = Console.ReadLine();
            if (answer != "")
                personToModify.Observations = answer;

            Personas[num] = personToModify;
        }
    }

    public void DrawTop(int cont)
    {
        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write(new string('-', 78));
        Console.Write("| Agenda (ficha actual:" + (cont + 1) + "/" + Personas.Count + "   " + DateTime.Now + "         Moisex y Raul       |");
        Console.WriteLine(new string('-', 78));
        Console.ResetColor();
    }

    public void DrawBottom()
    {
        Console.SetCursorPosition(0, Console.WindowHeight-4);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write(new string('-', 78));
        Console.Write(new string(' ', 78));
        Console.SetCursorPosition(0, Console.WindowHeight - 3);
        Console.Write("1-Anterior 2-Posterior 0-Salir");
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.WriteLine(new string('-', 78));
        Console.ResetColor();
    }
}

[Serializable]
public class Persona : IComparable
{
    public string Name { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Phone { get; set; }
    public string Observations { get; set; }

    public Persona(string nombre, string direccion1, string direccion2, string telefono, string observaciones)
    {
        Name = nombre;
        Address1 = direccion1;
        Address2 = direccion2;
        Phone = telefono;
        Observations = observaciones;
    }

    public Persona()
    {

    }

    public int CompareTo(object obj)
    {
        Persona actual = (Persona)obj;

        if (String.Compare(this.Name,
        actual.Name, true) > 0)
            return 1;
        else
            return -1;
    }
}