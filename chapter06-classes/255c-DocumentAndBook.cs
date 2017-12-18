// Gonzalo Martinez

using System;

public class Document
{
    protected string author;
    protected string title;
    protected int pages;
    
    public Document(string newAuthor, string newTitle, 
        int newPages)
    {
        author = newAuthor;
        title = newTitle;
        pages = newPages;
    }
    
    public Document()
    {
        
    }
    
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
    
    public string GetAuthor()
    {
        return author;
    }
    
    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }
    
    public string GetTitle()
    {
        return title;
    }
    
    public void SetPages(int newPages)
    {
        pages = newPages;
    }
    
    public int GetPages()
    {
        return pages;
    }
}

//---------------------------------------------------------------------

public class Book : Document
{
    
    protected int height;
    protected int width;
    
    public Book(string newAuthor, string newTitle, 
        int newPages, int newHeight, 
        int newWidth)
    {
        author = newAuthor;
        title = newTitle;
        pages = newPages;
        height = newHeight;
        width = newWidth;
    }
    
    public void SetHeight(int newHeight)
    {
        height = newHeight;
    }
    
    public int GetHeight()
    {
        return height;
    }
    
    public void SetWidth(int newWidth)
    {
        width = newWidth;
    }
    
    public int GetWidth()
    {
        return width;
    }
}

//---------------------------------------------------------------------

public class BookTest
{
    public static void Main(string[] args)
    {
        Document d = new Document("Jose", "Java", 300);
        Book b = new Book("Nacho", "Csharp", 100, 20, 20);
    }
}
