/*
Class Document (4) + constructors with "this"

Create a new version (4) of the class Document. The constructor with one 
parameter will be based on the constructor with three parameters.
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
    
    public Document(string title) : this (title, "", 0)
    {
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
            
        Document d2 = new Document("El Lazarillo de Tormes");
        Console.WriteLine("Pages 2: {0}",
            d2.GetPages() );
    }
}
