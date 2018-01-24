/*

Create a class PhotoAlbum. It must have a constructor which will receive the 
number of pages in the album and a method GetNumPages, which will return that 
amount, and a SetNumPages, to allow to change it later.

The constructor must use the same name for the attribute and for the parameter.

Create also an empty constructor, which will set the number of pages to 16. 

Create a method "ToString", which will return something like "Photoalbum - 20 
pages".

The Main will create an array of 4 PhotoAlbums, with different sizes, one of 
which will use the empty constructor. Also, you must display the data of those 
PhotoAlbums.

*/

using System;

public class PhotoAlbum
{
    protected int numberofPages;
    
    public PhotoAlbum() : this(16)
    {
    }

    public PhotoAlbum(int numberofPages)
    {
       this.numberofPages = numberofPages;
    }

    public int GetNumPages()
    {
        return numberofPages;
    }
    
    public void SetNumPages(int amount)
    {
        numberofPages = amount;
    }
    
    public override string ToString()
    {
        return "Photoalbum - " + 
            numberofPages + " pages";
    }
}


// --------

public class AlbumTest
{
    public static void Main()
    {
        PhotoAlbum[] myAlbums = new PhotoAlbum[4];
        myAlbums[0] = new PhotoAlbum(20);
        myAlbums[1] = new PhotoAlbum(40);
        myAlbums[2] = new PhotoAlbum();
        myAlbums[3] = new PhotoAlbum(10);
        
        foreach(PhotoAlbum p in myAlbums)
            Console.WriteLine( p );
    }
}
