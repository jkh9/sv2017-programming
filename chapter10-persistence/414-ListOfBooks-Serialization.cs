//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
struct Book : IComparable
{
    public string title;
    public string author;
    public short yearPublished;

    public int CompareTo(object b2)
    {
        if (String.Compare(  // Same title?
                title,
                ((Book)b2).title, true) == 0)
        {
            // Sort on author if the title is the same
            return String.Compare(
                author,
                ((Book)b2).author, true);
        }
        else
        {
            // Sort on title otherwise
            return String.Compare(
                author,
                ((Book)b2).author, true);
        }
    }
}

public class BooksCollection
{
    public static void Main()
    {
        List<Book> books = new List<Book>();

        string option;

        // If there is a data file, let's load it
        if (File.Exists("books.dat"))
        {
            IFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream("books.dat",
                FileMode.Open, FileAccess.Read,
                FileShare.Read);
            books = (List<Book>)formatter1.Deserialize(stream1);
            stream1.Close();
        }

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1.Add book");
            Console.WriteLine("2.Show books");
            Console.WriteLine("3.Search book by title/author.");
            Console.WriteLine("4.Search book by date.");
            Console.WriteLine("5.Update book.");
            Console.WriteLine("6.Delete book.");
            Console.WriteLine("7.Correct spelling in the titles.");
            Console.WriteLine("X.Exit");

            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                //Add a book
                case "1":

                    Book b;
                    string year;
                    Console.WriteLine("Book {0}:", books.Count + 1);

                    do
                    {
                        Console.Write("Enter the title: ");
                        b.title = Console.ReadLine();
                        if (b.title == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Title can't be empty.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (b.title == "");

                    do
                    {
                        Console.Write("Enter the author: ");
                        b.author = Console.ReadLine();
                        if (b.author == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Author can't be empty.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (b.author == "");

                    Console.Write("Enter the year published: ");
                    year = Console.ReadLine();
                    if (year != "")
                    {
                        b.yearPublished =
                            Convert.ToInt16(year);
                    }
                    else
                        b.yearPublished = -1;

                    books.Add(b);
                    books.Sort();

                    Console.Clear();
                    break;

                //Show books
                case "2":
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (i % 21 == 20)
                            Console.ReadLine();

                        Console.WriteLine("Book {0}", i + 1);
                        Console.WriteLine("Title: {0}", books[i].title);
                        Console.WriteLine("Author: {0}", books[i].author);
                        if (books[i].yearPublished == -1)
                            Console.WriteLine("Year: Unknown year");
                        else
                            Console.WriteLine("Year: {0}",
                                books[i].yearPublished);

                        Console.WriteLine();
                    }

                    break;

                //Search book by title/author
                case "3":
                    Console.Write("Enter the keywords: ");
                    string search = Console.ReadLine().ToLower();
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].title.ToLower().Contains(search)
                            || books[i].author.ToLower().Contains(search))
                        {
                            if (i % 21 == 20)
                                Console.ReadLine();

                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: {0}", books[i].title);
                            Console.WriteLine("Author: {0}", books[i].author);
                            if (books[i].yearPublished == -1)
                                Console.WriteLine("Year: Unknown year");
                            else
                                Console.WriteLine("Pages: {0}",
                                    books[i].yearPublished);
                        }

                        Console.WriteLine();
                    }

                    break;

                //Seach book with two dates
                case "4":
                    Console.Write("Enter the first date: ");
                    short date1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter the second date: ");
                    short date2 = Convert.ToInt16(Console.ReadLine());

                    if (date1 > date2)
                    {
                        short dateAux = date1;
                        date1 = date2;
                        date2 = dateAux;
                    }

                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].yearPublished >= date1 &&
                            books[i].yearPublished <= date2)
                        {
                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: {0}", books[i].title);
                            Console.WriteLine("Author: {0}", books[i].author);
                            Console.WriteLine("Year: {0}",
                                books[i].yearPublished);

                            Console.WriteLine();
                        }
                    }

                    break;

                //Update book/record
                case "5":
                    Console.Write("Enter the record num: ");
                    int recordPos = Convert.ToInt32(Console.ReadLine());
                    recordPos--;

                    if (recordPos < 0 || recordPos >= books.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        string answer;
                        bool spaces = false;
                        Book bookToEdit = books[recordPos];

                        Console.WriteLine("Book {0}", recordPos + 1);

                        //Title
                        Console.WriteLine("The title was: {0}",
                            books[recordPos].title);
                        Console.Write("Enter the new title: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            bookToEdit.title = answer;

                        //Author
                        Console.WriteLine("The author was: {0}",
                            books[recordPos].author);
                        Console.Write("Enter the new author: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            bookToEdit.author = answer;

                        //Year
                        if (books[recordPos].yearPublished == -1)
                            Console.WriteLine("The year was: Unknown year");
                        else
                            Console.WriteLine("the year was: {0}",
                                books[recordPos].yearPublished);
                        Console.Write("Enter the new year: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            bookToEdit.yearPublished =
                                Convert.ToInt16(answer);

                        books[recordPos] = bookToEdit;

                        //Uppercase, Lowercase and redundant spaces
                        if (books[recordPos].title
                                == books[recordPos].title.ToUpper())
                            Console.WriteLine("The title is completely uppercase");
                        else if (books[recordPos].title
                                == books[recordPos].title.ToLower())
                            Console.WriteLine("The title is completely lowercase");

                        string[] fragments = books[recordPos].title.Split();

                        for (int i = 0; i < fragments.Length; i++)
                        {
                            if (fragments[i] == "")
                                spaces = true;
                        }
                        if (spaces)
                            Console.WriteLine
                                ("The title contains redundant spaces.");

                        spaces = false;

                        if (books[recordPos].author
                                == books[recordPos].author.ToUpper())
                            Console.WriteLine("The author is completely uppercase");
                        else if (books[recordPos].author
                                == books[recordPos].author.ToLower())
                            Console.WriteLine("The author is completely lowercase");

                        fragments = books[recordPos].author.Split();

                        for (int i = 0; i < fragments.Length; i++)
                        {
                            if (fragments[i] == "")
                                spaces = true;
                        }
                        if (spaces)
                            Console.WriteLine
                                ("The author contains redundant spaces.");
                    }

                    break;

                //Delete book/record
                case "6":
                    Console.Write("Enter the record num: ");
                    int bookPos = Convert.ToInt32(Console.ReadLine());
                    bookPos--;

                    if (bookPos < 0 || bookPos >= books.Count)
                    {
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        Console.WriteLine("Book {0}", bookPos + 1);
                        Console.WriteLine("Title: {0}", books[bookPos].title);
                        Console.WriteLine("Author: {0}", books[bookPos].author);
                        if (books[bookPos].yearPublished == -1)
                            Console.WriteLine("Year: Unknown year");
                        else
                            Console.WriteLine("Pages: {0}",
                                books[bookPos].yearPublished);

                        Console.Write("Delete this book?(yes/no)");
                        string answer = Console.ReadLine().ToLower();
                        Console.Clear();

                        if (answer == "yes")
                        {
                            books.RemoveAt(bookPos);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Successfully removed");
                            Console.ResetColor();
                        }
                    }

                    break;

                //Show books with incorrect spelling and correct them
                case "7":
                    bool displayRecord;
                    //Show incorrect records
                    for (int i = 0; i < books.Count; i++)
                    {
                        StringBuilder strBuild;
                        displayRecord = false;
                        //Uppercase rigth after a lowercase
                        strBuild = new StringBuilder(books[i].title);

                        for (int j = 0; j < strBuild.Length - 1
                            && !displayRecord; j++)
                        {
                            if (strBuild[j].ToString().ToLower()
                                    == books[i].title[j].ToString()
                                    && strBuild[j + 1].ToString().ToUpper()
                                    == books[i].title[j + 1].ToString())
                                displayRecord = true;
                        }

                        //Consecutive spaces
                        string[] splitTitles = books[i].title.Split();
                        for (int j = 0; j < splitTitles.Length && !displayRecord; j++)
                        {
                            if (splitTitles[j] == "")
                                displayRecord = true;

                        }
                        //Leading and trailing spaces
                        if (!displayRecord && books[i].title[0] == ' ' ||
                        books[i].title[books[i].title.Length - 1] == ' ')
                            displayRecord = true;

                        //Display incorrect record
                        if (displayRecord)
                        {
                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: {0}", books[i].title);
                            Console.WriteLine("Author: {0}", books[i].author);
                            if (books[i].yearPublished == -1)
                                Console.WriteLine("Year: Unknown year");
                            else
                                Console.WriteLine("Pages: {0}",
                                    books[i].yearPublished);

                            //Fix record
                            Console.Write("Do you want to fix this record (y/n)?");
                            if (Console.ReadLine() == "y")
                            {
                                string[] splitTitle;

                                Book bookToFix = books[i];
                                //Delete consecutive spaces
                                splitTitle = books[i].title.Split();
                                bookToFix.title = "";
                                for (int j = 0; j < splitTitle.Length; j++)
                                {
                                    if (splitTitle[j] != "")
                                        bookToFix.title += splitTitle[j] + " ";
                                }

                                //Delete leading or trailing 
                                bookToFix.title = bookToFix.title.Trim();

                                //First letter to uppercase and the ones after a dot
                                strBuild =
                                    new StringBuilder(bookToFix.title.ToLower());
                                strBuild[0] -= ' ';

                                for (int j = 1; j < strBuild.Length; j++)
                                {
                                    if (strBuild[j] == '.'
                                        && j < strBuild.Length - 1)
                                    {
                                        if (strBuild[j + 1] == ' ')
                                            strBuild[j + 2] -= ' ';
                                        else
                                            strBuild[j + 1] -= ' ';
                                    }
                                }
                                bookToFix.title = strBuild.ToString();

                                books[i] = bookToFix;
                                //
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Record fixed.");
                                Console.ResetColor();
                            }
                        }
                    }

                    break;

                case "x":
                    Console.WriteLine("Bye!");
                    break;

                default:
                    Console.WriteLine("Unknown option");
                    break;
            }

        } while (option != "x");

        // And let's save the data
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("books.dat",
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(stream, books);
        stream.Close();
    }
}