/*

Class Document (8) + Book + calling order

Create a new version (8) in which the constructor of Document will display 
"Creating a Document" and the constructor of Book will display "Creating a 
Book". Test it from Main, creating a book and seeing what happens.

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
        Console.WriteLine("Creating a document");
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
}

// -------------------------------------------------------------------------

public class Book : Document
{
    protected char cover;
    
    public Book(string title,string author,int pages,char cover) 
        : base(title, author, pages)
    {
        this.cover = cover;
        Console.WriteLine("Creating a book");
    }
    
    public void SetCover(char newCover)
    {
        cover = newCover;
    }
    
    public char GetCover()
    {
        return cover;
    }
}

// -------------------------------------------------------------------------

public class DocumentsTest
{
    public static void Main()
    {
        /*
        Document[] documents = new Document[3];
        for(int i = 0; i < 3; i++)
        {
            documents[i] = new Document("WW" + (i+1), 
                "author" + (i+1), 
                100);
        }
        
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Title: " + documents[i].GetTitle());
            Console.WriteLine("Author: " + documents[i].GetAuthor());
            Console.WriteLine("Pages: " + documents[i].GetPages());
            Console.WriteLine();
        }
        */
        
        Book b = new Book("El Quijote", "Cervantes", 2000, 'H');
    }
}
