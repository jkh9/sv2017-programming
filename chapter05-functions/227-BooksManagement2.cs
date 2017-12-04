// Books management V3 (functions + parameters)

using System;

public struct book
{
    public string title;
    public string author;
    public short numPages;
}

public class StructsBooks
{
    public static void Add(ref book[] books, ref int count)
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

    public static void ShowAll(book[] books, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Title: " + books[i].title);
            Console.WriteLine("Author: " + books[i].author);
            Console.WriteLine("NumPages: " + books[i].numPages);
            Console.WriteLine();
        }
    }


    public static void Search(book[] books, int count)
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
        book[] books = new book[10000];
        int count = 0;

        bool finished = false;
        do
        {
            switch (ShowMenuAndGetOption())
            {
                case "1": Add(ref books, ref count); break;
                case "2": ShowAll(books, count); break;
                case "3": Search(books, count); break;
                case "0": finished = true; break;
                default: WarnAboutWrongOption(); break;
            }
        }
        while (!finished);
        Console.WriteLine("Bye!");
    }
}
