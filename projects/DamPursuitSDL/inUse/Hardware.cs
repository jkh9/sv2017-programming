using System;
using Tao.Sdl;

public static class Hardware
{
    public const int KEY_ESC = Sdl.SDLK_ESCAPE;
    public const int KEY_UP = Sdl.SDLK_UP;
    public const int KEY_DOWN = Sdl.SDLK_DOWN;
    public const int KEY_LEFT = Sdl.SDLK_LEFT;
    public const int KEY_RIGHT = Sdl.SDLK_RIGHT;
    public const int KEY_SPACE = Sdl.SDLK_SPACE;

    static short screenWidth;
    static short screenHeight;
    static short colorDepth;
    static IntPtr screen;

    static Hardware()
    {
        screenWidth = 800;
        screenHeight = 600;
        colorDepth = 24;
    }

    public static void Show(short width, short height, short colorBits)
    {
        screenWidth = width;
        screenHeight = height;
        colorDepth = colorBits;

        int flags = Sdl.SDL_HWSURFACE | Sdl.SDL_DOUBLEBUF |
            Sdl.SDL_ANYFORMAT;
        Sdl.SDL_Init(Sdl.SDL_INIT_EVERYTHING);
        screen = Sdl.SDL_SetVideoMode(screenWidth, screenHeight,
            colorDepth, flags);
        Sdl.SDL_Rect rect = new Sdl.SDL_Rect(0, 0, screenWidth,
            screenHeight);
        Sdl.SDL_SetClipRect(screen, ref rect);
    }

    public static void DrawImage(Image img)
    {
        Sdl.SDL_Rect source = new Sdl.SDL_Rect(0, 0, img.ImageWidth,
            img.ImageHeight);
        Sdl.SDL_Rect target = new Sdl.SDL_Rect(img.X, img.Y, img.ImageWidth,
            img.ImageHeight);
        Sdl.SDL_BlitSurface(img.ImagePtr, ref source, screen, ref target);
    }

    public static void UpdateScreen()
    {
        Sdl.SDL_Flip(screen);
    }

    public static int KeyPressed()
    {
        int pressed = -1;
        Sdl.SDL_PumpEvents();
        Sdl.SDL_Event keyEvent;
        if (Sdl.SDL_PollEvent(out keyEvent) == 1)
        {
            if (keyEvent.type == Sdl.SDL_KEYDOWN)
            {
                pressed = keyEvent.key.keysym.sym;
            }
        }
        return pressed;
    }

    public static void ClearScreen()
    {
        Sdl.SDL_Rect source = new Sdl.SDL_Rect(0, 50, screenWidth,
        (short)(screenHeight-50));
        Sdl.SDL_FillRect(screen, ref source, 0);
    }

    public static bool IsKeyPressed(int key)
    {
        bool pressed = false;
        Sdl.SDL_PumpEvents();
        Sdl.SDL_Event evt;
        Sdl.SDL_PollEvent(out evt);
        int numKeys;
        byte[] keys = Sdl.SDL_GetKeyState(out numKeys);
        if (keys[key] == 1)
            pressed = true;
        return pressed;
    }

    public static void DrawSprite(Image image, short xScreen, short yScreen,
        short x, short y, short width, short height)
    {
        Sdl.SDL_Rect src = new Sdl.SDL_Rect(x, y, width, height);
        Sdl.SDL_Rect dest = new Sdl.SDL_Rect(xScreen, yScreen, width, height);
        Sdl.SDL_BlitSurface(image.ImagePtr, ref src, screen, ref dest);
    }

    public static void DrawSquare(short x, short y, short x2, short y2, byte r, byte g,
        byte b, byte alpha)
    {
        SdlGfx.rectangleRGBA(screen, x, y,x2, y2, r, g, b, alpha);
        Hardware.UpdateScreen();
    }
}

