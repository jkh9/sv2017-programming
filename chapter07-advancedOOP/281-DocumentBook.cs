/*
Class Document (6) + Book
Create a new version (6) in which you will add a new class Book, 
inheriting from Document. This new class will contain one attribute, 
"cover", a "char" ("H" for Hardcover, "P" for Paperback).
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
    
    public Document()  // !!!!!!!!
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
    {
        this.cover = cover;
        this.title = title;
        this.author = author;
        this.pages = pages;
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
        
        Book b = new Book("El Quijote", "Cervantes", 2000, 'H');
        Document wtf = new Document();  // !!!!!!
    }
}
