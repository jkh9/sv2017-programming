/*
Class Document (2) + this

Create a new version (2) of the class Document, using the same name for the 
attribute and for the parameter in the constructor.
*/

using System;

public class Document
{
    protected string title;
    protected string author;
    protected int pages;
    
    public Document(string title, 
        string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
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
}

public class DocumentTest
{
    public static void Main()
    {
        Document d = new Document(
            "El Quijote", "Cervantes", 2000);
        Console.WriteLine("Pages: {0}",
            d.GetPages() );
    }
}
