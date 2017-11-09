/*
    Books management V1
    Francisco Sabater Villora
*/
using System;

struct book
{
    public string title;
    public string author;
    public short numPages;
}

public class StructcsBooks
{
    public static void Main()
    {
        book[] books = new book[10000];
        string option;
        int count = 0;
        
        do
        {
            Console.WriteLine("1.- Add");
            Console.WriteLine("2.- Show all");
            Console.WriteLine("3.- Search");
            Console.WriteLine("0.- Exit");
            Console.Write("Enter a option: ");
            option = Console.ReadLine();
            
            switch( option )
            {
                case "1":
                    Console.Write("Enter title: ");
                    books[count].title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    books[count].author = Console.ReadLine();
                    Console.Write("Enter num pages: ");
                    books[count].numPages = Convert.ToInt16(Console.ReadLine());
                    count++;
                    Console.WriteLine();
                    break;

                case "2":
                    for(int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Title: " + books[i].title);
                        Console.WriteLine("Author: " + books[i].author);
                        Console.WriteLine("NumPages: " + books[i].numPages);
                        Console.WriteLine();
                    }
                    break;

                case "3":
                    Console.Write("Enter a text to search: ");
                    string search = Console.ReadLine();
                    
                    for(int i = 0; i < count; i++)
                    {
                        if( books[i].title.ToUpper().Contains( search.ToUpper() )  ||
                            books[i].author.ToUpper().Contains( search.ToUpper() ))
                        {
                            Console.WriteLine("Title: " + books[i].title);
                            Console.WriteLine("Author: " + books[i].author);
                            Console.WriteLine("NumPages: " + books[i].numPages);
                            Console.WriteLine();
                        }
                    }
                    break;

                case "0":
                    Console.WriteLine("Bye!");
                    break;

                default:
                    Console.WriteLine("Wrong option, enter a valid option");
                    Console.WriteLine();
                    break;
            }
        } 
        while ( option != "0" );
    }
}
