// Books management V2 (functions)

using System;

struct book
{
    public string title;
    public string author;
    public short numPages;
}

public class StructsBooks
{
    static book[] books = new book[10000];
    static int count = 0;

    public static void Add()
    {
        Console.Write("Enter title: ");
        books[count].title = Console.ReadLine();
        Console.Write("Enter author: ");
        books[count].author = Console.ReadLine();
        Console.Write("Enter num pages: ");
        books[count].numPages = Convert.ToInt16(Console.ReadLine());
        count++;
        Console.WriteLine();
    }

    public static void ShowAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Title: " + books[i].title);
            Console.WriteLine("Author: " + books[i].author);
            Console.WriteLine("NumPages: " + books[i].numPages);
            Console.WriteLine();
        }
    }


    public static void Search()
    {
        Console.Write("Enter a text to search: ");
        string search = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (books[i].title.ToUpper().Contains(search.ToUpper()) ||
                books[i].author.ToUpper().Contains(search.ToUpper()))
            {
                Console.WriteLine("Title: " + books[i].title);
                Console.WriteLine("Author: " + books[i].author);
                Console.WriteLine("NumPages: " + books[i].numPages);
                Console.WriteLine();
            }
        }
    }

    public static string ShowMenuAndGetOption()
    {
        Console.WriteLine("1.- Add");
        Console.WriteLine("2.- Show all");
        Console.WriteLine("3.- Search");
        Console.WriteLine("0.- Exit");
        Console.Write("Enter a option: ");
        return Console.ReadLine();
    }

    public static void WarnAboutWrongOption()
    {
        Console.WriteLine("Wrong option, enter a valid option");
        Console.WriteLine();
    }

    public static void Main()
    {
        bool finished = false;
        do
        {
            switch ( ShowMenuAndGetOption() )
            {
                case "1": Add(); break;
                case "2": ShowAll(); break;
                case "3": Search(); break;
                case "0": finished = true; break;
                default: WarnAboutWrongOption(); break;
            }
        }
        while ( ! finished );
        Console.WriteLine("Bye!");
    }
}
