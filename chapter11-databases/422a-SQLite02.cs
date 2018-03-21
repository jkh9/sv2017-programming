using System;
using System.Data.SQLite;

public class SQLite02
{
    public static void Main(string[] args)
    {
        SQLiteConnection connection =
            new SQLiteConnection
            ("Data Source=cars01.sqlite;Version=3;New=False; Compress=True;");
        connection.Open();
        string query = "select * from cars";
        SQLiteCommand cmd = new SQLiteCommand(query, connection);
        SQLiteDataReader data = cmd.ExecuteReader();
        while (data.Read())
        {
            string brand = Convert.ToString(data[0]);
            string model = Convert.ToString(data[1]);
            int power = Convert.ToInt32(data[2]);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: "+model);
            Console.WriteLine("Power: " + power);
        }
        connection.Close();
    }
}
