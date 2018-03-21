using System;
using System.Data.SQLite;

public class SQLite01
{
    public static void Main(string[] args)
    {
        

        SQLiteConnection connection =
            new SQLiteConnection
            ("Data Source=cars01.sqlite; Version=3;New=True;Compress=True;");
        connection.Open();

        string creation = "create table cars ("
            + " brand varchar(15),model varchar(30),power int);";
        SQLiteCommand cmd = new SQLiteCommand(creation, connection);
        cmd.ExecuteNonQuery();

        string insertion = "insert into cars values "
            +" ('Ford', 'Sierra 2.0i Ghia', 105);";
        cmd = new SQLiteCommand(insertion, connection);
        int amount = cmd.ExecuteNonQuery();
        if (amount < 1)
            Console.WriteLine("Insertion failed");
        connection.Close();
    }
}
