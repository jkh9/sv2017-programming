/*

Class Document (13) + Book + array + override

Use virtual + override to improve the previous exercise

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
    
    public virtual void ShowData()
    {
        Console.Write("Author = " + author 
            + ", Title = " + title);
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
    }    
   
    public void SetCover(char newCover)
    {
        cover = newCover;
    }
    
    public char GetCover()
    {
        return cover;
    }
    
    public override void ShowData()
    {
        Console.Write("Author = " + author 
            + ", Title = " + title
            + ", Cover = " + cover);
    }
}

// -------------------------------------------------------------------------

public class DocumentsTest
{
    public static void Main()
    {
        Document[] documents = new Document[5];
        for(int i = 0; i < 5; i++)
        {
            if (i % 2 == 1)
                documents[i] = new Book("B" + (i+1), 
                    "author" + (i+1), 
                    100, 'P');
            else
                documents[i] = new Document("D" + (i+1), 
                    "author" + (i+1), 
                    100);
        }
        
        for(int i = 0; i < 5; i++)
        {
            documents[i].ShowData();
            Console.WriteLine();
        }
        
        Book b = new Book("El Quijote", "Cervantes", 2000, 'H');
        b.ShowData();
        
        Console.WriteLine();
        
        Document b2 = new Book("Dr.No", "Ian Fleming", 243, 'P');
        b2.ShowData();
    }
}
