//Daniel Miquel Sirera
//Exercise 286

using System;

class WindowTest
{
    static void Main()
    {
        Window[] win = new Window[10];
        Random r = new Random();

        for (int i = 0; i <10; i++)
        {
            int w = r.Next(40, 101);
            int h = r.Next(90, 121);

            win[i] = new Window(w, h);
        }

        for(int i = 0; i < 10; i++)
        {
            win[i].ShowData();
        }
    }
}

//----------------------------------------

class Window
{
    protected int width;
    protected int height;

    public Window(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void SetWidth(int Nwidth)
    {
        width = Nwidth;
    }

    public int GetWidth()
    {
        return width;
    }

    public void SetHeight(int Nheight)
    {
        height = Nheight;
    }

    public int GetHeight()
    {
        return height;
    }

    public void ShowData()
    {
        Console.WriteLine("Width: "+width);
        Console.WriteLine("Heigth: "+height);
    }
}
