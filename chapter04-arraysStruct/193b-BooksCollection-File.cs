/*
Create a C# program that can store up to 25000 books. For each book, it must 
allow the user to store the following information:

- Title (e.g. The shining)
- Author (e.g. Stephen King)
- Year published (e.g. 1977)

The program should allow the user to perform the following operations :

1 - Add a new book. The title and author cannot be empty. An empty year should 
be stored as a -1. Data must be automatically sorted on title and (if 
necessary) author after each new data is added.

2 - Show all the books (record number, title, author and year), pausing after 
every 21 rows. If no year was entered, you must display "Unknown year" instead 
of -1.

3 - Find books containing a certain text (partial search, in any text field, 
not case sensitive). You must display the record number, the title, author and 
year, pausing after every 21 rows.

4 - Find books published between two dates (for example, 1970 and 1985), both 
included. Again, you must display the record number, the title, author and 
year, but there is no need for pause. It must behave correctly if the user 
enters the later date first.

5 - Update a record: ask the user for its number, display the previous value of 
each field and allow the user to press Enter if they choose not to modify any 
of the data. They should be warned (but not asked again) if they enter an 
incorrect record number. Before storing the data, leading and trailing spaces 
should be removed. The user will be warned if title or author are completely 
uppercase, completely lowercase or contains redundant spaces.

6 - Delete a record, in the position entered by the user. They should be warned 
(but not asked again) if they enter an incorrect record number. It should 
display the record to be deleted and ask for confirmation before the deletion.

7 - Correct spelling in the titles: it will display the records containing two 
consecutive spaces, leading or trailing spaces, or an uppercase letter right 
after a lowercase letter. After displaying each record, it will ask the user 
"Do you want to fix this record (y/n)?" If the user answers "y", the program 
will remove trailing spaces, leading spaces and duplicated spaces and turn the 
text lo lowercase, except for the first letter and the ones after a dot, only 
in the title.

X - eXit the application (as we do not store the information on file, data will 
be lost). 
*/

// Victor Tebar
//

using System;
using System.IO;
using System.Text;

struct Book
{
    public string title;
    public string author;
    public short yearPublished;
}

public class Ejer193
{
    public static void Main()
    {
        const int NUM_BOOKS = 25000;
        Book[] books = new Book[NUM_BOOKS];

        int arrayPos = 0;
        string option;

        // If there is a data file, let's load it
        if (File.Exists("books.dat"))
        {
            string[] dataFromFile = File.ReadAllLines("books.dat");
            for (int i = 0; i < dataFromFile.Length / 3; i++)
            {
                books[i].title = dataFromFile[i * 3];
                books[i].author = dataFromFile[i * 3 + 1];
                books[i].yearPublished = Convert.ToInt16(
                    dataFromFile[i * 3 + 2]);
            }
            arrayPos = dataFromFile.Length / 3;
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
                    if (arrayPos < NUM_BOOKS)
                    {
                        string year;
                        Console.WriteLine("Book {0}:", arrayPos + 1);

                        do
                        {
                            Console.Write("Enter the title: ");
                            books[arrayPos].title = Console.ReadLine();
                            if (books[arrayPos].title == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Title can't be empty.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (books[arrayPos].title == "");

                        do
                        {
                            Console.Write("Enter the author: ");
                            books[arrayPos].author = Console.ReadLine();
                            if (books[arrayPos].author == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Author can't be empty.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (books[arrayPos].author == "");

                        Console.Write("Enter the year published: ");
                        year = Console.ReadLine();
                        if (year != "")
                        {
                            books[arrayPos].yearPublished =
                                Convert.ToInt16(year);
                        }
                        else
                            books[arrayPos].yearPublished = -1;

                        arrayPos++;

                        //Sort
                        for (int i = 0; i < arrayPos - 1; i++)
                        {
                            for (int j = i + 1; j < arrayPos; j++)
                            {
                                if (String.Compare(books[i].title, books[j].title,
                                    true) > 0)
                                {
                                    Book bookAux = books[i];
                                    books[i] = books[j];
                                    books[j] = bookAux;
                                }
                                else if (books[i].title == books[j].title)
                                {
                                    if (String.Compare(books[i].author,
                                        books[j].author, true) > 0)
                                    {
                                        Book bookAux = books[i];
                                        books[i] = books[j];
                                        books[j] = bookAux;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The database is full.");
                        System.Threading.Thread.Sleep(2000);
                    }

                    Console.Clear();
                    break;

                //Show books
                case "2":
                    for (int i = 0; i < arrayPos; i++)
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
                    for (int i = 0; i < arrayPos; i++)
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

                    for (int i = 0; i < arrayPos; i++)
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

                    if (recordPos < 0 || recordPos >= arrayPos)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        string answer;
                        bool spaces = false;

                        Console.WriteLine("Book {0}", recordPos + 1);

                        //Title
                        Console.WriteLine("The title was: {0}",
                            books[recordPos].title);
                        Console.Write("Enter the new title: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            books[recordPos].title = answer;


                        //Author
                        Console.WriteLine("The author was: {0}",
                            books[recordPos].author);
                        Console.Write("Enter the new author: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            books[recordPos].author = answer;


                        //Year
                        if (books[recordPos].yearPublished == -1)
                            Console.WriteLine("The year was: Unknown year");
                        else
                            Console.WriteLine("the year was: {0}",
                                books[recordPos].yearPublished);
                        Console.Write("Enter the new year: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            books[recordPos].yearPublished =
                                Convert.ToInt16(answer);

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

                    if (bookPos < 0 || bookPos >= arrayPos)
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
                            for (int i = bookPos; i < arrayPos - 1; i++)
                            {
                                books[i] = books[i + 1];
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Successfully removed");
                            Console.ResetColor();
                            arrayPos--;
                        }
                    }

                    break;

                //Show books with incorrect spelling and correct them
                case "7":
                    bool displayRecord;
                    //Show incorrect records
                    for (int i = 0; i < arrayPos; i++)
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

                                //Delete consecutive spaces
                                splitTitle = books[i].title.Split();
                                books[i].title = "";
                                for (int j = 0; j < splitTitle.Length; j++)
                                {
                                    if (splitTitle[j] != "")
                                        books[i].title += splitTitle[j] + " ";
                                }

                                //Delete leading or trailing 
                                books[i].title = books[i].title.Trim();

                                //First letter to uppercase and the ones after a dot
                                strBuild =
                                    new StringBuilder(books[i].title.ToLower());
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
                                books[i].title = strBuild.ToString();
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
        string[] dataToFile = new string[arrayPos * 3];
        for (int i = 0; i < arrayPos; i++)
        {
            dataToFile[i * 3] = books[i].title;
            dataToFile[i * 3 + 1] = books[i].author;
            dataToFile[i * 3 + 2] = books[i].yearPublished.ToString();
        }
        File.WriteAllLines("books.dat", dataToFile);

    }
}
