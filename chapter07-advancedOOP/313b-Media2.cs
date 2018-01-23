/*

Create a class "Media", to let you save information about a generic multimedia 
file. It will have as attributes: author, size (in KB), format (eg MPEG4). You 
must also create the "getters" and "settters" to read or change these 
attributes. Create also a constructor, to assign a value to the three 
attributes when creating an object.

Create a class "Image", inheriting from "Media" and add the attributes "width" 
(eg, 1600), and "height", with their corresponding Set and Get, as well as a 
specific constructor.

Create a class "Sound", also based on "Media", with the extra the attributes 
"stereo" (boolean), "kbps" (eg, 192), and "length" (in seconds), their setters 
and getters and a constructor.

Create a class "Video", also descending from "Media", which will add the 
attributes "codec" (eg H.264), "width" (eg 1600), "heigth" and "length" (in 
seconds), their setters and getters and a reasonable constructor.

Finally, create a class "MediaTest". with a test program that creates at least 
one item from each of the above types, as well as an array with at least two 
elements of different types and then display their data on screen.

*/

// Javier Herreros Pozo

using System;

public class Media
{
    protected string author;
    protected int sizeKb;
    protected string format;

    public Media(string newAuthor, int newSizeKb, string newFormat)
    {
        this.author = newAuthor;
        this.sizeKb = newSizeKb;
        this.format = newFormat;
    }

    public string GetAuthor()
    {
        return author;
    }

    public int GetSize()
    {
        return sizeKb;
    }

    public string GetFormat()
    {
        return format;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    public void SetSize(int newSizeKb)
    {
        sizeKb = newSizeKb;
    }

    public void SetFormat(string newFormat)
    {
        format = newFormat;
    }
    // Note: Missing ToString method
}


public class Image : Media
{
    protected int width;
    protected int height;

    public Image(int newWidth, int newHeight, string newAuthor, int newSizeKb,
            string newFormat) : base(newAuthor, newSizeKb, newFormat)
    {
        this.width = newWidth;
        this.height = newHeight;
    }

    public int GetWidth()
    {
        return width;
    }

    public void SetWidth(int newWidth)
    {
        width = newWidth;
    }

    public int GetHeight()
    {
        return height;
    }

    public void SetHeight(int newHeight)
    {
        height = newHeight;
    }
    
    // Note: Missing ToString method
}


public class Sound : Media
{
    protected bool stereo;
    protected int kbps;
    protected int lengthSec;

    public Sound(bool newStereo, int newKbps, int newLengthSec, string newAuthor
            , int newSizeKb, string newFormat) : base(newAuthor, newSizeKb,
            newFormat)
    {
        this.stereo = newStereo;
        this.kbps = newKbps;
        this.lengthSec = newLengthSec;
    }

    public bool GetStereo()
    {
        return stereo;
    }

    public void SetStereo(bool newStereo)
    {
        stereo = newStereo;
    }

    public int GetKbps()
    {
        return kbps;
    }

    public void SetKbps(int newKbps)
    {
        kbps = newKbps;
    }

    public int GetLengthSec()
    {
        return lengthSec;
    }

    public void SetLengthSec(int newLengthSec)
    {
        lengthSec = newLengthSec;
    }
    
    // Note: Missing ToString method
}


public class Video : Media
{
    protected string codec;
    protected int width;
    protected int height;

    public Video(int newWidth, int newHeight, string newCodec, int newLengthSec,
            string newAuthor, int newSizeKb, string newFormat) :
            base(newAuthor, newSizeKb, newFormat)
    {
        this.codec = newCodec;
        this.width = newWidth;
        this.height = newHeight;
    }
    public string GetCodec()
    {
        return codec;
    }

    public void SetCodec(string newCodec)
    {
        codec = newCodec;
    }

    public int GetWidth()
    {
        return width;
    }

    public void SetWidth(int newWidth)
    {
        width = newWidth;
    }

    public int GetHeight()
    {
        return height;
    }

    public void SetHeight(int newHeight)
    {
        height = newHeight;
    }
    
    // Note: Missing ToString method
}



class MediaTest
{
    static void Main()
    {
        //TO DO
    }
}

