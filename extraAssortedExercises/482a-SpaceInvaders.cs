//Raul, Angel, Pedro
using System;

public class MyGame
{
public struct brick
{
public byte x;
public byte y;
public byte numberOfHits;
public ConsoleColor color;
public bool destroyed;
public byte score;
}

public struct ball
{
public byte x;
public byte y;
public sbyte xDirection;
public bool ballDisplayed;
}

public const int BAR_WIDTH = 5;

public static void PrintBorder()
{
Console.BackgroundColor = ConsoleColor.Gray;

for (int i = 40; i < 79; i++)
{
Console.SetCursorPosition(i, 0);
Console.Write(" ");
Console.SetCursorPosition(i, 23);
Console.Write(" ");
}
for (int i = 0; i < 24; i++)
{
Console.SetCursorPosition(40, i);
Console.Write(" ");
Console.SetCursorPosition(79, i);
Console.Write(" ");
}

Console.ResetColor();
}

public static void PrintTexts()
{
Console.ForegroundColor = ConsoleColor.Green;
Console.SetCursorPosition(52, 4);
Console.Write("Space Invaders");

Console.ForegroundColor = ConsoleColor.Red;
Console.SetCursorPosition(42, 9);
Console.Write("Lives");

Console.ForegroundColor = ConsoleColor.Green;
Console.SetCursorPosition(42, 12);
Console.Write("Score");

Console.ResetColor();
}

public static brick[] CreateBricks()
{
brick[] bricks = new brick[40];

for (int i = 0; i < bricks.Length; i++)
{
bricks[i].x = (byte)((i % 10) * 4);
bricks[i].y = (byte)(2 + (i / 10));
bricks[i].destroyed = false;
if (i >= 14 && i <= 15)
{
bricks[i].numberOfHits = 2;
bricks[i].color = ConsoleColor.Yellow;
bricks[i].score = 50;
}
else if (i % 2 == 0 && (i / 10) % 2 == 0 || i % 2 == 1 && (i / 10) % 2 == 1)
{
bricks[i].numberOfHits = 1;
bricks[i].color = ConsoleColor.Blue;
bricks[i].score = 20;
}
else
{
bricks[i].numberOfHits = 1;
bricks[i].color = ConsoleColor.Red;
bricks[i].score = 10;
}
}

return bricks;
}

public static void DrawBricks(brick[] bricks)
{
for (int i = 0; i < bricks.Length; i++)
{
Console.SetCursorPosition(bricks[i].x, bricks[i].y);
Console.Write("x");
}
}

public static ball InitBall(int characterX, int characterY)
{
ball gameBall;

gameBall.x = (byte)(characterX + 2);
gameBall.y = (byte)(characterY + 1);
gameBall.ballDisplayed = false;
gameBall.xDirection = 0;

return gameBall;
}

public static void GetUserInput(ref int characterX, int characterY, ref ball gameBall, ref bool exitGame)
{
ConsoleKeyInfo key;
Console.CursorVisible = false;

Console.SetCursorPosition(0, 24);

if (Console.KeyAvailable)
{
do
{
key = Console.ReadKey(false);
} while (Console.KeyAvailable);

Console.SetCursorPosition(characterX, characterY);
Console.ResetColor();
Console.Write("     ");

if (key.Key == ConsoleKey.LeftArrow && characterX > 0)
characterX--;
if (key.Key == ConsoleKey.RightArrow && characterX + BAR_WIDTH < 40)
characterX++;
if (key.Key == ConsoleKey.Spacebar)
{
gameBall.x = (byte)(characterX + 2);
gameBall.y += 1;
gameBall.xDirection = 1;
}
if (key.Key == ConsoleKey.Escape)
exitGame = true;
}
}

public static void MoveBall(ref ball gameBall)
{
Console.ResetColor();
Console.SetCursorPosition(gameBall.x, gameBall.y);
Console.Write(" ");
if (gameBall.y <= Console.WindowHeight)
gameBall.y -= 1;
}
public static void CollisionBallBricks(ref ball gameBall, brick[] bricks, ref int totalScore)
{
for (int i = 0; i < bricks.Length; i++)
{
if (!bricks[i].destroyed)
{
if ((gameBall.y == bricks[i].y + 1 && gameBall.y < 0 || gameBall.y == bricks[i].y - 1 && gameBall.y > 0) && gameBall.x >= bricks[i].x && gameBall.x < bricks[i].x + 4)
{
    bricks[i].numberOfHits--;
    gameBall.y = 22;
}
if (bricks[i].numberOfHits == 0)
{
    bricks[i].destroyed = true;
    totalScore += bricks[i].score;
    PrintScore(totalScore);
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(bricks[i].x, bricks[i].y);
    Console.Write("    ");
    Console.ResetColor();
}
}
}
}

public static int CollisionBallBoundaries(ref ball gameBall)
{
if (gameBall.y == 0)
{
gameBall.y = 22;
}
return gameBall.y;
}

public static void PrintScore(int totalScore)
{
Console.SetCursorPosition(50, 12);
Console.ForegroundColor = ConsoleColor.White;
Console.Write(totalScore);
Console.ResetColor();
}

public static void PrintLives(int lives)
{
Console.SetCursorPosition(50, 7);
for (int i = 0; i < 25; i++)
Console.Write(" ");
Console.BackgroundColor = ConsoleColor.White;
for (int i = 0; i < lives; i++)
{
Console.SetCursorPosition(50 + i * (BAR_WIDTH + 2), 7);
Console.Write("     ");
}
Console.ResetColor();
}

public static void ResetPositions(ref ball gameBall, ref int characterX, int characterY)
{
Console.SetCursorPosition(characterX, characterY);
Console.Write("     ");
Console.SetCursorPosition(gameBall.x, gameBall.y);
Console.Write(" ");
characterX = 18;
gameBall = InitBall(characterX, characterY);
}

public static void Main()
{
int characterX = 18, characterY = 23;
ball gameBall = InitBall(characterX, characterY);

bool moveBall = true;

brick[] bricks = CreateBricks();

bool exitGame = false;

int totalScore = 0;
int lives = 3;

PrintBorder();
PrintTexts();
PrintLives(lives);
PrintScore(totalScore);
DrawBricks(bricks);
while (!exitGame)
{
moveBall = !moveBall;

Console.SetCursorPosition(gameBall.x, gameBall.y);
Console.Write("o");

Console.SetCursorPosition(characterX, characterY);
Console.BackgroundColor = ConsoleColor.White;
Console.Write("     ");
Console.ResetColor();

System.Threading.Thread.Sleep(50);


GetUserInput(ref characterX, characterY, ref gameBall, ref exitGame);

if (moveBall)
{
MoveBall(ref gameBall);
}

if (moveBall)
{

CollisionBallBricks(ref gameBall, bricks, ref totalScore);
if (gameBall.y == 0)
{
CollisionBallBoundaries(ref gameBall);
}

}
}
Console.SetCursorPosition(0, 23);
}
}
