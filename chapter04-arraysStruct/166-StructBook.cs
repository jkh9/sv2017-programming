// Create a "struct" to store a few data of a book: title (string), 
// author (string), numPages (short)

// Gonzalo Martinez

using System;

struct book
{
    public string title;
    public string author;
    public short numPages;
}

public class Ex166
{
    public static void Main()
    {
        book b1;
        Console.Write("Enter the title: ");
        b1.title = Console.ReadLine();
        Console.Write("Enter the author: ");
        b1.author = Console.ReadLine();
        Console.Write("Enter the num of pages: ");
        b1.numPages = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine(b1.title);
        Console.WriteLine(b1.author); 
        Console.WriteLine(b1.numPages);  
    }
}
