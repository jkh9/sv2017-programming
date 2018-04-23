using System;
using Tao.Sdl;

public class Font{
    IntPtr fontType;

    public Font(string fileName, int fontSize)
    {
        fontType = SdlTtf.TTF_OpenFont(fileName, fontSize);
        if (fontType == IntPtr.Zero)
        {
            Console.WriteLine("Font type not found");
            //Environment.Exit(2);
        }
    }

    public IntPtr GetFontType()
    {
        return fontType;
    }
}

