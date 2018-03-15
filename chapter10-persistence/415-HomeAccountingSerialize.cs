/*
Home accounting, full version (exam of 2011-2012)
Crea un programa en C# que pueda almacenar hasta 10000 gastos e ingresos, para 
crear un pequeño sistema de contabilidad doméstica. Para cada gasto (o 
ingreso), debe permitir guardar los siguientes datos:
Fecha (8 caracteres: formato AAAAMMDD)
Descripción del gasto o ingreso
Categoría
Importe (positivo si es un ingreso, negativo si es un gasto)
El programa debe permitir al usuario realizar las siguientes operaciones:
1-  Añadir un nuevo gasto (la fecha debe "parecer correcta": día de 01 a 31, 
mes de 01 a 12, año entre 1000 y 3000). La descripción no debe estar vacía. No 
hace falta validar los demás datos.
2- Mostrar todos los gastos de una cierta categoría (por ejemplo, "estudios") 
entre dos ciertas fechas (por ejemplo entre "20110101" y "20111231"). Se 
mostrará número, fecha (en formato DD/MM/AAAA), descripción, categoría entre 
paréntesis, e importe con dos decimales, todo ello en la misma línea, separado 
por guiones. Al final de todos los datos se mostrará el importe total de los 
datos mostrados.
3- Buscar gastos que contengan un cierto texto (en la descripción o en la 
categoría, sin distinguir mayúsculas ni minúsculas). Se mostrará número, fecha 
y descripción (la descripción se mostrará truncada en el sexto espacio en 
blanco, en caso de existir seis espacios o más).
4- Modificar una ficha (pedirá el número de ficha al usuario; se mostrará el 
valor anterior de cada campo y se podrá pulsar Intro para no modificar alguno 
de los datos). Se debe avisar (pero no volver a pedir) si el usuario introduce 
un número de ficha incorrecto. No hace falta validar ningún dato.
5- Borrar un cierto dato, a partir del número que indique el usuario. Se debe 
avisar (pero no volver a pedir) si introduce un número incorrecto. Se debe 
mostrar la ficha que se va a borrar y pedir confirmación antes de proceder al 
borrado.
6- Ordenar los datos alfabéticamente, según fecha y (en caso de coincidir) 
descripción.
7- Normalizar descripciones: eliminar espacios finales, espacios iniciales y 
espacios duplicados. Si alguna descripción está totalmente en mayúsculas, se 
convertirá a minúsculas (excepto la primera letra, que se conservará en 
mayúsculas).
T- Terminar el uso de la aplicación (como no sabemos almacenar la información, 
los datos se perderán).
*/

// Señor Santana, corrections by Señor Cabanes

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class HomeFunctions
{
    const ushort SIZE = 10000;
    static ig[] movements = new ig[SIZE];
    static int cont = 0;
    static int numMove;

    [Serializable]
    public struct ig
    {
        public string date;
        public string description;
        public string category;
        public double amount;
    }
    
    public static void Save(ig[] movements, int cont)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("accounting.dat",
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(stream, movements);
        formatter.Serialize(stream, cont);
        stream.Close();
    }

    public static void Load(out ig[] movements, out int count)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("accounting.dat",
            FileMode.Open, FileAccess.Read,
            FileShare.Read);
        movements = (ig[]) formatter.Deserialize(stream);
        count = (int) formatter.Deserialize(stream);
        stream.Close();
    }


    public static void Add()
    {
        string year, month, day;
        if (cont < SIZE)
        {
            do
            {
                Console.Write("Enter year: ");
                year = Console.ReadLine();
            }
            while ((Convert.ToInt32(year) < 1000) ||
                (Convert.ToInt32(year) > 3000));

            do
            {
                Console.Write("Enter month: ");
                month = Console.ReadLine();
            }
            while ((Convert.ToInt32(month) < 1) ||
                (Convert.ToInt32(month) > 12));
            if (month.Length == 1)
                month = "0" + month;

            do
            {
                Console.Write("Enter day: ");
                day = Console.ReadLine();
            }
            while ((Convert.ToInt32(day) < 1) ||
                (Convert.ToInt32(day) > 31));
            if (day.Length == 1)
                day = "0" + day;
            movements[cont].date = year + month + day;

            do
            {
                Console.Write("Description: ");
                movements[cont].description = Console.ReadLine();

                if (movements[cont].description == "")
                    Console.WriteLine("Description cannot be empty");

            } while (movements[cont].description == "");

            Console.Write("Category: ");
            movements[cont].category = Console.ReadLine();

            Console.Write("Amount: ");
            movements[cont].amount =
                Convert.ToDouble(Console.ReadLine());

            cont++;
        }
        else
            Console.WriteLine("No room");
    }

    public static void ShowExpense()
    {
        double sumTotal = 0;
        if (cont > 0)
        {
            Console.Write("Category: ");
            string auxCategory = Console.ReadLine();
            Console.Write("From: ");
            int fromDate = Convert.ToInt32(Console.ReadLine());
            Console.Write("To: ");
            int toDate = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cont; i++)
            {
                if (movements[i].category.Contains(auxCategory)
                    && (Convert.ToInt32(movements[i].date)
                        >= fromDate &&
                    Convert.ToInt32(movements[i].date)
                        <= toDate))
                {
                    Console.WriteLine((i + 1) + " - " +
                    movements[i].date.Substring(6, 2) + "/" +
                    movements[i].date.Substring(4, 2) + "/" +
                    movements[i].date.Substring(0, 4) + " - " +
                    movements[i].description + " - (" +
                    movements[i].category + ") - " +
                    movements[i].amount.ToString("0.00"));
                    sumTotal += movements[i].amount;
                }
            }
            Console.WriteLine("Total amount: " +
                sumTotal.ToString("0.00"));
        }
        else
            Console.WriteLine("There are no expenses");
    }

    public static void Search(bool found)
    {
        Console.Write("Search: ");
        string search = Console.ReadLine().ToUpper();

        if (cont > 0)
        {
            for (int i = 0; i < cont; i++)
            {
                int contSpaces = 0;
                int numList = i + 1;

                if (movements[i].description.ToUpper().Contains(search) ||
                    movements[i].category.ToUpper().Contains(search))
                {
                    Console.Write((numList) + " - " +
                    movements[i].date.Substring(6, 2) + "/" +
                    movements[i].date.Substring(4, 2) + "/" +
                    movements[i].date.Substring(0, 4) + " - ");

                    foreach (char c in movements[i].description)
                    {
                        if (c == ' ')
                            contSpaces++;
                        if (contSpaces <= 6)
                            Console.Write(c);
                    }
                    Console.WriteLine();
                    found = true;
                }
            }
            if (found == false)
                Console.WriteLine("Not found");
        }
        else
            Console.WriteLine("There are no expenses");
    }

    public static void ModifyMovementData()
    {
        Console.Write("Number of movement: ");
        numMove = Convert.ToUInt16(Console.ReadLine()) - 1;
        if (numMove >= 0 && numMove < cont)
        {
            Console.WriteLine("Date (" +
                movements[numMove].date + "): ");
            string answer = Console.ReadLine();
            if (answer != "")
                movements[numMove].date = answer;

            Console.WriteLine("Category (" +
                movements[numMove].category + "): ");
            answer = Console.ReadLine();
            if (answer != "")
                movements[numMove].category = answer;

            Console.WriteLine("Description ("
                + movements[numMove].description + "): ");
            answer = Console.ReadLine();
            if (answer != "")
                movements[numMove].description = answer;

            Console.WriteLine("Amount ("
                + movements[numMove].amount + "): ");
            answer = Console.ReadLine();
            if (answer != "")
            {
                movements[numMove].amount =
                    Convert.ToDouble(answer);
            }
        }
        else
            Console.WriteLine("Wrong number");
    }

    public static void Delete()
    {
        Console.Write("Number of movement: ");
        numMove = Convert.ToUInt16(Console.ReadLine()) - 1;
        string confirm = "";
        if (numMove >= 0 && numMove < cont)
        {
            Console.WriteLine("Are you sure? S/N");
            confirm = Console.ReadLine();

            if (confirm == "S" || confirm == "s")
            {
                for (int i = numMove; i < cont - 1; i++)
                    movements[i] = movements[i + 1];

                cont--;
                Console.WriteLine("Delete successful");
            }
            else
                Console.WriteLine("Delete not processed");
        }
        else
            Console.WriteLine("Wrong number");
    }

    public static void Sort()
    {
        for (int i = 0; i < cont - 1; i++)
        {
            for (int j = i + 1; j < cont; j++)
            {
                if (movements[i].date.CompareTo(movements[j].date)
                    > 0)
                {
                    ig aux = movements[j];
                    movements[j] = movements[i];
                    movements[i] = aux;
                }
                else if (movements[i].date == movements[j].date
                    && String.Compare(movements[i].description,
                        movements[j].description, true) > 0)
                {
                    ig aux = movements[j];
                    movements[j] = movements[i];
                    movements[i] = aux;
                }
            }
        }
        Console.WriteLine("Data stored!");
    }

    public static void Normalize()
    {
        for (int i = 0; i < cont; i++)
        {
            // Leading and trailing spaces
            movements[i].description =
                movements[i].description.Trim();

            // Duplicated spaces
            while (movements[i].description.Contains("  "))
                movements[i].description = movements[i].description.
                    Replace("  ", " ");

            // Correct case
            if (movements[i].description ==
                movements[i].description.ToUpper())
            {
                movements[i].description =
                    movements[i].description.Substring(0, 1).ToUpper() +
                    movements[i].description.Substring(1).ToLower();
            }
        }
    }

    public static void LoadData()
    {
        // If there is a data file, let's load it
        if (File.Exists("accounting.dat"))
        {
            Load(out movements, out cont);
        }
    }

    public static void SaveData()
    {
        Save(movements, cont);
    }

    public static string ShowMenuAndGetOption()
    {
        Console.WriteLine("1. Add expense");
        Console.WriteLine("2. Show expense");
        Console.WriteLine("3. Search");
        Console.WriteLine("4. Modify movement data");
        Console.WriteLine("5. Delete movement");
        Console.WriteLine("6. Sort alphabetically");
        Console.WriteLine("7. Normalize descriptions");
        Console.WriteLine("t. Exit");
        Console.Write("Option: ");
        return Console.ReadLine().ToLower();
    }

    public static void FinishProgram(ref bool finished)
    {
        finished = true;
        Console.WriteLine("Bye!");
    }

    public static void WrongOption()
    {
        Console.WriteLine("Wrong option!");
    }

    public static void Main()
    {
        bool finished = false;
        LoadData();
        do
        {
            Console.Clear();
            bool found = false;

            switch (ShowMenuAndGetOption())
            {
                case "1": Add(); break;
                case "2": ShowExpense(); break;
                case "3": Search(found); break;
                case "4": ModifyMovementData(); break;
                case "5": Delete(); break;
                case "6": Sort(); break;
                case "7": Normalize(); break;
                case "t": FinishProgram(ref finished); break;
                default: WrongOption(); break;
            }

            if (!finished)
            {
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }

        } while (!finished);
        SaveData();
    }
}
