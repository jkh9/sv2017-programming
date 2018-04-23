using System;
using System.Collections.Generic;
using System.Threading;
using Tao.Sdl;

struct Tile
{
    public short X;
    public short Y;
    public Category category;
}
class GameScreen
{
    List<Question> questions;
    Tile[] tiles = new Tile[28];
    Image player;
    Image board;
    int tile;
    Image dice;
    Sprite[] diceFaces;
    Font font;

    public GameScreen()
    {
        player = new Image("imgs/character.png", 110,82);
        board = new Image("imgs/Dam-Pursuit-bg.png", 1024, 576);
        font = new Font("fonts/prince_valiant.ttf", 20);
        questions = Question.LoadQuestions();
        CrearCasillas();
        tile = 0;
        Move();
        DrawDice();
    }

    ~GameScreen()
    {
        Question.SaveQuestions(questions);
    }

    public void Show()
    {
        bool exit = false;
        bool pulsed = false;
        Random r = new Random();
        int number = -1;

        Refresh();
        do
        {
            int keyPressed = Hardware.KeyPressed();

            //MOVE
            switch (keyPressed)
            {
                case Hardware.KEY_SPACE:
                    number = r.Next(0, 6);
                    pulsed = true;
                    break;
                case Hardware.KEY_ESC:
                    exit = true;
                    break;
                default:
                    break;
            }

            if (pulsed)
            {
                Refresh();
                DrawDice(number);
                number++;
                int actualTile = tile;
                if (tile + number > 27)
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (tile + 1 == 28)
                        {
                            tile = -1;
                        }
                        tile++;
                    }
                    DrawSquare("green", tiles[tile]);
                }
                else
                {
                    DrawSquare("green", tiles[tile + number]);
                }

                tile = actualTile;
                if (tile - number < 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (tile - 1 == -1)
                        {
                            tile = 28;
                        }
                        tile--;
                    }
                    DrawSquare("red", tiles[tile]);
                }
                else
                {
                    DrawSquare("red", tiles[tile - number]);
                }
                pulsed = false;
                tile = actualTile;
            }
            //PAUSE
            Thread.Sleep(50);

        } while (!exit);
    }

    public void CrearCasillas()
    {
        //Casillas arriba
        for (int i = 0; i < 7; i++)
        {
            tiles[i] = new Tile
            {
                X = (short)(14 + (i*92) + (i*5)),
                Y = 86,
            };
        }

        //Casillas derecha
        for (int i = 0; i < 7; i++)
        {
            tiles[i+7] = new Tile
            {
                X = 693,
                Y = (short)(86 + (i) + (i*58)),
            };
        }

        //Casillas abajo
        for (int i = 0; i < 7; i++)
        {
            tiles[i+14] = new Tile
            {
                X = (short)(693 - (i * 92) - (i * 5)),
                Y = 526,
            };
        }

        //Casillas izquierda
        for (int i = 0; i < 7; i++)
        {
            tiles[i+21] = new Tile
            {
                X = 14,
                Y = (short)(526 - (i) - (i * 58)),
            };
        }

        tiles[0].category = Category.Databases;
        tiles[1].category = Category.Programming;
        tiles[2].category = Category.Systems;
        tiles[3].category = Category.Web;
        tiles[4].category = Category.Databases;
        tiles[5].category = Category.Programming;
        tiles[6].category = Category.Systems;
        tiles[7].category = Category.Web;

        tiles[8].category = Category.Systems;
        tiles[9].category = Category.Web;
        tiles[10].category = Category.Databases;
        tiles[11].category = Category.Systems;
        tiles[12].category = Category.Programming;
        tiles[13].category = Category.Databases;

        tiles[14].category = Category.Programming;
        tiles[15].category = Category.Databases;
        tiles[16].category = Category.Web;
        tiles[17].category = Category.Programming;
        tiles[18].category = Category.Databases;
        tiles[19].category = Category.Systems;
        tiles[20].category = Category.Web;
        tiles[21].category = Category.Systems;

        tiles[22].category = Category.Web;
        tiles[23].category = Category.Programming;
        tiles[24].category = Category.Databases;
        tiles[25].category = Category.Web;
        tiles[26].category = Category.Systems;
        tiles[27].category = Category.Programming;
    }

    public void Refresh()
    {
        Hardware.ClearScreen();
        Hardware.DrawImage(board);
        Hardware.DrawImage(player);
        Hardware.UpdateScreen();
    }

    private void Move()
    {
        player.MoveTo((short)(tiles[tile].X - 8), (short)(tiles[tile].Y - 22));
    }

    private void DrawDice()
    {
        dice = new Image("imgs/dice.png",640,320);
        diceFaces = new Sprite[6];

        for (int i = 0; i < 6; i++)
        {
            diceFaces[i] = new Sprite((short)((3*i) +(i*104)-i),107, 104, 105);
        }
    }

    private void DrawDice(int number)
    {
        Hardware.DrawSprite(dice, (short)(790 - (diceFaces[number].Width)), 2,
                    diceFaces[number].X, diceFaces[number].Y,
                    diceFaces[number].Width, diceFaces[number].Height);
        Hardware.UpdateScreen();
    }

    private void DrawSquare(string color, Tile current)
    {
        if (color == "green")
        {
            Hardware.DrawSquare(current.X, current.Y, (short)(current.X+72), (short)(current.Y+57), 0, 190, 0, 255);
        }
        else if (color == "red")
        {
            Hardware.DrawSquare(current.X, current.Y, (short)(current.X + 72), (short)(current.Y+57), 255, 0, 0, 255);
        }
    }
}
