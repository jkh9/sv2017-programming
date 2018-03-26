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

// Daniel Miquel

using System;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;

public class HomeFunctions
{
    public static void CreateDatabase()
    {
        if (!File.Exists("homeAccounting.sqlite"))
        {
            SQLiteConnection connection =
                new SQLiteConnection
                ("Data Source=homeAccounting.sqlite; Version=3;"
                    + "New=True;Compress=True;");
            connection.Open();
            string creation =
                "create table accounting("
                    + " id int primary key,"
                    + " date varchar(8),"
                    + " description varchar(50),"
                    + " category varchar(20),"
                    + " amount numeric(10,2) );";
            SQLiteCommand cmd = new SQLiteCommand(creation, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }

    public static int AlterDatabase(string query)
    {
        SQLiteConnection connection =
                new SQLiteConnection
                ("Data Source=homeAccounting.sqlite; "
                    + "Version=3;New=False;Compress=True;");
        connection.Open();
        SQLiteCommand cmd = new SQLiteCommand(query, connection);
        int alteredData = cmd.ExecuteNonQuery();
        connection.Close();
        return alteredData;
    }

    public static List<string> SearchDatabase(string query)
    {
        SQLiteConnection connection =
                new SQLiteConnection
                ("Data Source=homeAccounting.sqlite; "
                    + "Version=3;New=False;Compress=True;");
        connection.Open();
        SQLiteCommand cmd = new SQLiteCommand(query, connection);

        SQLiteDataReader data = cmd.ExecuteReader();

        List<string> answer = new List<string>();

        while (data.Read())
        {
            int id = Convert.ToInt32(data[0]);
            string date = Convert.ToString(data[1]);
            string description = Convert.ToString(data[2]);
            string category = Convert.ToString(data[3]);
            double amount = Convert.ToDouble(data[4]);

            answer.Add("id: " + id);
            answer.Add("Date: " + date); // TO DO
            answer.Add("Description: " + description);
            answer.Add("Category: " + category);
            answer.Add("Amount: " + amount);
            answer.Add("");
        }
        connection.Close();
        return answer;
    }

    public static string GetOneField(string query)
    {
        SQLiteConnection connection =
                new SQLiteConnection
                ("Data Source=homeAccounting.sqlite; "
                    + "Version=3;New=False;Compress=True;");
        connection.Open();
        SQLiteCommand cmd = new SQLiteCommand(query, connection);
        SQLiteDataReader data = cmd.ExecuteReader();
        string answer = "";
        if (data.Read())
           answer = Convert.ToString(data[0]);
        connection.Close();
        return answer;
    }

    public static void Add()
    {
        string year, month, day, date, description, category;
        int amount;

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
        date = year + month + day;

        do
        {
            Console.Write("Description: ");
            description = Console.ReadLine();

            if (description == "")
                Console.WriteLine("Description cannot be empty");

        } while (description == "");

        Console.Write("Category: ");
        category = Console.ReadLine();

        Console.Write("Amount: ");
        amount =
            Convert.ToInt32(Console.ReadLine());

        string maxAsString = GetOneField("SELECT MAX(id) FROM accounting;");
        if (maxAsString == "")
            maxAsString = "0";
        int max = Convert.ToInt32(maxAsString);

        string insertion = "insert into accounting values "
            + " (" + (max+1) + ",'" + date + "', '" + description 
            + "', '" + category + "'," + amount + ");";
        int result = AlterDatabase(insertion);
        if (result < 1)
            Console.WriteLine("Insertion failed");
    }

    public static void ShowExpense()
    {
        SQLiteConnection connection = new SQLiteConnection
               ("Data Source=homeAccounting.sqlite; "
                + "Version=3;New=False;Compress=True;");

        Console.Write("Enter category:");
        string category = Console.ReadLine();
        string year, month, day, date1, date2;

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

        date1 = year + month + day;

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
        date2 = year + month + day;

        string select = "select * from accounting where category LIKE '%"
            + category + "%' and date > '" + date1 + "' and date < '" + date2 + "';";
        List<string> data = SearchDatabase(select);
        foreach (string s in data)
            Console.WriteLine(s);
    }

    public static void Search(bool found)
    {
        Console.Write("Search: ");
        string search = Console.ReadLine().ToUpper();

        string select = "select * from accounting where description LIKE '%"
            + search + "%';";
        List<string> data = SearchDatabase(select);
        foreach (string s in data)
            Console.WriteLine(s);
    }

    public static void ModifyMovementData()
    {
        Console.Write("Number of movement: ");
        int numMove = Convert.ToUInt16(Console.ReadLine());
        int max = Convert.ToInt32(
            GetOneField("SELECT MAX(id) FROM accounting;"));
        if (numMove >= 1 && numMove <= max)
        {
            string date = GetOneField(
                "SELECT date FROM accounting WHERE id=" + numMove + ";");
            Console.WriteLine("Date (" +
                date + "): ");
            string answer = Console.ReadLine();
            if (answer != "")
                date = answer;

            string category = GetOneField(
                "SELECT category FROM accounting WHERE id=" + numMove + ";");
            Console.WriteLine("Category (" +
                category + "): ");
            answer = Console.ReadLine();
            if (answer != "")
                category = answer;

            string description = GetOneField(
                "SELECT description FROM accounting WHERE id=" + numMove + ";");
            Console.WriteLine("Description ("
                + description + "): ");
            answer = Console.ReadLine();
            if (answer != "")
                description = answer;

            double amount = Convert.ToDouble(GetOneField(
                "SELECT amount FROM accounting WHERE id=" + numMove + ";"));
            Console.WriteLine("Amount ("
                + amount + "): ");
            answer = Console.ReadLine();
            if (answer != "")
                amount = Convert.ToDouble(answer);

            string command = "UPDATE accounting "
                + " SET description = '" + description + "', "
                + " category = '" + category + "', "
                + " date = '" + date + "', "
                + " amount = " + amount + " "
                + " WHERE id = " + numMove + ";";
            int result = AlterDatabase(command);
            if (result < 1)
                Console.WriteLine("Update not succesful");
        }
        else
            Console.WriteLine("Wrong number");
    }

    public static void Delete()
    {
        Console.Write("Number of movement: ");
        int numMove = Convert.ToUInt16(Console.ReadLine());
        string confirm = "";
        int max = Convert.ToInt32(
            GetOneField("SELECT MAX(id) FROM accounting;"));
        if (numMove >= 1 && numMove <= max)
        {
            Console.WriteLine("Are you sure? S/N");
            confirm = Console.ReadLine();

            if (confirm == "S" || confirm == "s")
            {
                int result = AlterDatabase("DELETE FROM accounting WHERE id=" 
                    + numMove);
                if (result < 1)
                    Console.WriteLine("Delete not succesful");
            }
            else
                Console.WriteLine("Delete not processed");
        }
        else
            Console.WriteLine("Wrong number");
    }


    public static void Normalize()
    {
        // Note: not used right now
        int result = AlterDatabase("UPDATE accounting SET description = " +
                "TRIM(description)");
        Console.WriteLine(result + " rows trimmed");
    }

    public static string ShowMenuAndGetOption()
    {
        Console.WriteLine("1. Add expense");
        Console.WriteLine("2. Show expense");
        Console.WriteLine("3. Search");
        Console.WriteLine("4. Modify movement data");
        Console.WriteLine("5. Delete movement");
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
        CreateDatabase();
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
                //case "7": Normalize(); break;
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
    }
}
