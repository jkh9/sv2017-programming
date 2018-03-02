// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Added a bubble
//     Pause after each frame

//v0.03 28-feb-2018
//     Ángel Rebollo Berná, Almudena Lopez Sanchez, Daniel Miquel Sirera
//     Added Support for Sdl libraries
//     Added class Hardware and image
//     Created constructor on Hardware and Image clases
//     Included Sprites for all Fishes
using System;
using Tao.Sdl;

public class Image
{
    public short X { get; set; }
    public short Y { get; set; }
    public short ImageWidth { get; set; }
    public short ImageHeight { get; set; }
    public IntPtr ImagePtr { get; set; }

    public Image(string fileName, short width, short height)
    {
        ImagePtr = SdlImage.IMG_Load(fileName);
        if (ImagePtr == IntPtr.Zero)
        {
            Console.WriteLine("Image not found");
            Environment.Exit(1);
        }

        ImageWidth = width;
        ImageHeight = height;
    }

    public void MoveTo(short x, short y)
    {
        X = x;
        Y = y;
    }
}


