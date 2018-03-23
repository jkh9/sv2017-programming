// SQLite Countries
// Gonzalo Martinez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SQLiteCountry
{
    class Program
    {
        static void CreateDatabase()
        {
            SQLiteConnection connection =
                new SQLiteConnection
                ("Data Source=countries.sqlite;Version=3;New=True;Compress=True");
            connection.Open();
            string creation = "create table country(name varchar(15), capital varchar(15), area int);";
            SQLiteCommand cmd = new SQLiteCommand(creation, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        static void Main(string[] args)
        {
            if(!File.Exists("countries.sqlite"))
            {
                CreateDatabase();
            }

            SQLiteConnection connection =
                new SQLiteConnection
                ("Data Source=countries.sqlite;Version=3;New=False;Compress=True");
            connection.Open();

            bool finished = false;
            byte option;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show all");
                Console.WriteLine("3. Search in names");
                Console.WriteLine("4. Search in text");
                Console.WriteLine("0. Exit");

                option = Convert.ToByte(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("--Add a country(name, capital, area)--");
                        Console.WriteLine();
                        Console.WriteLine("Name of the country: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Capital of the country: ");
                        string capital = Console.ReadLine();
                        Console.WriteLine("Area of the country: ");
                        int area = Convert.ToInt32(Console.ReadLine());

                        string insertion = "insert into country values('"+ name +
                            "', '" + capital + "', " + area + ");";
                        SQLiteCommand cmd = new SQLiteCommand(insertion, connection);
                        int amount = cmd.ExecuteNonQuery();
                        if (amount < 1)
                            Console.WriteLine("Insertion failed");
                        break;
                    case 2:
                        string query = "select name, capital, area from country;";
                        cmd = new SQLiteCommand(query, connection);
                        SQLiteDataReader data = cmd.ExecuteReader();
                        int count = 0;
                        while (data.Read())
                        {
                            if(count % 24 == 23)
                            {
                                Console.ReadLine();
                            }
                            name = Convert.ToString(data[0]);
                            capital = Convert.ToString(data[1]);
                            area = Convert.ToInt32(data[2]);
                            Console.WriteLine("Name: " + name + ", capital: " + 
                                capital + ", area: " + area);
                            count++;
                        }
                        break;
                    case 3:
                        Console.Write("Country name to search for... ");
                        string search = Console.ReadLine();
                        query = "select name, capital, area from country" +
                            "where name = '" + search + "';";
                        cmd = new SQLiteCommand(query, connection);
                        data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            name = Convert.ToString(data[0]);
                            capital = Convert.ToString(data[1]);
                            area = Convert.ToInt32(data[2]);
                            Console.WriteLine("Name: " + name + ", capital: " +
                                capital + ", area: " + area);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Text to find... ");
                        string search = Console.ReadLine();
                        query = "select name, capital, area from country" +
                            "where name like '%" + search + "%' " +
                            "or capital like '%" + search + "%';";
                        cmd = new SQLiteCommand(query, connection);
                        data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            name = Convert.ToString(data[0]);
                            capital = Convert.ToString(data[1]);
                            area = Convert.ToInt32(data[2]);
                            Console.WriteLine("Name: " + name + ", capital: " +
                                capital + ", area: " + area);
                        }
                        break;
                    case 0:
                        finished = true;
                        connection.Close();
                        break;
                    default:
                        Console.WriteLine("Not a possible option!");
                        break;
                }

            } while (!finished);
        }
    }
}
