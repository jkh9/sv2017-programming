/*

Class Document (15) + Book + ToString

Create a method "ToString", both in Document and Book

*/

using System;

public class Document
{
    protected string title;
    protected string author;
    protected int pages;

    public Document(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }

    public Document(string title) : this(title, "", 0)
    {
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    public void SetPages(int newPages)
    {
        pages = newPages;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public int GetPages()
    {
        return pages;
    }

    public override string ToString()
    {
        return "Author = " + author
            + ", Title = " + title;
    }

    public virtual void ShowData()
    {
        Console.Write( this );
    }
}

// -------------------------------------------------------------------------

public class Book : Document
{
    protected char cover;

    public Book(string title, string author, int pages, char cover)
        : base(title, author, pages)
    {
        this.cover = cover;
    }

    public void SetCover(char newCover)
    {
        cover = newCover;
    }

    public char GetCover()
    {
        return cover;
    }

    public override string ToString()
    {
        return base.ToString()
            + ", Cover = " + cover;
    }

    public override void ShowData()
    {
        Console.Write( this );
    }
}

// -------------------------------------------------------------------------

public class DocumentsTest
{
    public static void Main()
    {
        Document[] documents = new Document[5];
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 1)
                documents[i] = new Book("B" + (i + 1),
                    "author" + (i + 1),
                    100, 'P');
            else
                documents[i] = new Document("D" + (i + 1),
                    "author" + (i + 1),
                    100);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(documents[i]);
        }

        Book b = new Book("El Quijote", "Cervantes", 2000, 'H');
        Console.WriteLine(b);

        Document b2 = new Book("Dr.No", "Ian Fleming", 243, 'P');
        Console.WriteLine(b2);
    }
}
