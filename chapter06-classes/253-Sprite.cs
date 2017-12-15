public class Sprite
{
    protected int x;
    protected int y;
    protected char symbol;

    public Sprite(int newX, int newY, char newSymbol)
    {
        x = newX;
        y = newY;
        symbol = newSymbol;
    }
    
    public Sprite()
    {
        x = 1;
        y = 1;
        symbol = 'X';
    }

    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetSymbol() { return symbol; }

    public void SetX(int nx) { x = nx; }
    public void SetY(int ny) { y = ny; }
    public void SetSymbol(char s) { symbol = s; }

    public void Display()
    {
        System.Console.SetCursorPosition(x, y);
        System.Console.Write(symbol);
    }
}
