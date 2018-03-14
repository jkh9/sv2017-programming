//Raul Gogna

using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[Serializable]
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public short Pages { get; set; }
    
    public Book(string title, string author, short pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public static void Save(Book b)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("book.dat",
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, b);
        stream.Close();
    }

    public static Book Load()
    {
        Book b;
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("Book.dat",
            FileMode.Open, FileAccess.Read, FileShare.Read);
        b = (Book)formatter.Deserialize(stream);
        stream.Close();
        return b;
    }
}

class Ex413
{
    public static void Main(string[] args)
    {
        Book b = new Book("That", "Raul Gogna", 25);
        Console.WriteLine(b.Title + "  " + 
			b.Author + " " + b.Pages);
        Book.Save(b);
        
        b.Author = "Don Daniel";
        b.Title = "No me ha dado tiempo";
        b.Pages = 3;        
        Console.WriteLine(b.Title + "  " + 
			b.Author + " " + b.Pages);
			
        b = Book.Load();
        Console.WriteLine(b.Title + "  " + 
			b.Author + " " + b.Pages);
    }
}

