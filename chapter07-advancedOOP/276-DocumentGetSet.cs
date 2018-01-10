/*
Create a class Document, with attributes for the title, author and number of 
pages. It must have a constructor which will receive the three attributes, as 
well as getters and setters for those atributes. 

In "Main", you must create a Document (any author and title, 5 pages), and then 
display its amount of pages.
*/

//Miguel García Gil

using System;

public class Document
{
    protected string title;
    protected string author;
    protected int pages;
    
    public Document(string newTitle, 
        string newAuthor, int newPages)
    {
        title = newTitle;
        author = newAuthor;
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
