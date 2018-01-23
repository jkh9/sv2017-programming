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

// Javier Saorin

using System;

class Media
{
    public string Author { get; set; }
    public int SizeKb { get; set; }
    public string Format { get; set; }

    public Media(string author, int size, string format)
    {
        Author = author;
        SizeKb = size;
        Format = format;
    }
    
    // Note: Missing ToString method
}


class Image : Media
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Image(string author, int size, string format, int width, int height) 
        : base(author, size, format)
    {
        Height = height;
        Width = width;
    }
    
    // Note: Missing ToString method
}


class Sound : Media
{
    public bool Stereo { get; set; }
    public int Kbps { get; set; }
    public int Length { get; set; }

    public Sound(string author, int size, string format, bool stereo, int kbps,
        int length)
        : base(author, size, format)
    {
        Stereo = stereo;
        Kbps = kbps;
        Length = length;
    }
    
    // Note: Missing ToString method
}


class Video : Image
{
    public string Codec { get; set; }
    public int Length { get; set; }

    public Video(string author, int size, string format, int width,
        int height, string codec, int length)
        : base(author, size, format, width, height)
    {
        Codec = codec;
        Length = length;
    }
    
    // Note: Missing ToString method
}


class MediaTest
{
    static void Main()
    {
        const int SIZE = 3;
        Media[] media = new Media[SIZE];

        Image i1 = new Image("Dalí", 0, "Óleo", 2000, 1000);
        Sound s1 = new Sound("Me", 500, "MP3",true, 1000, 500);
        Video v1 = new Video("Anónimo", 356, "VHS", 800, 600, "H.264", 30);

        media[0] = i1;
        media[1] = s1;
        media[2] = v1;
        
        foreach (Media m in media)
            Console.WriteLine(m);
    }
}

