/*
Class Document (5) + array

Create a new version (5) in which the class Document will not change, but Main 
will create an array of 3 Documents, with different authors, titles and amount 
of pages.
*/

// Gonzalo Martinez

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
}

// -------------------------------------------------------------------------

public class Ex280
{
    public static void Main()
    {
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
    }
}
