using System;
using System.Collections.Generic;
using System.Threading;

struct Casilla
{
    public short X;
    public short Y;
    public Categoria categoria;
}
class GameScreen
{
    List<Pregunta> preguntas;
    Casilla[] casillas = new Casilla[28];
    Image player;
    Image tablero;
    int casilla;
    Image dado;
    Sprite[] carasDado;

    public GameScreen()
    {
        player = new Image("imgs/character.png", 110,82);
        tablero = new Image("imgs/Dam-Pursuit-bg.png", 1024, 576);
        preguntas = Pregunta.LoadPreguntas();
        CrearCasillas();
        casilla = 0;
        Move();
        CrearDado();
    }

    ~GameScreen()
    {
        Pregunta.SavePreguntas(preguntas);
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
                DrawDado(number);
                number++;
                int casillaActual = casilla;
                if (casilla + number > 27)
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (casilla + 1 == 28)
                        {
                            casilla = -1;
                        }
                        casilla++;
                    }
                    DrawSquare("verde", casillas[casilla]);
                }
                else
                {
                    DrawSquare("verde", casillas[casilla + number]);
                }

                casilla = casillaActual;
                if (casilla - number < 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (casilla - 1 == -1)
                        {
                            casilla = 28;
                        }
                        casilla--;
                    }
                    DrawSquare("rojo", casillas[casilla]);
                }
                else
                {
                    DrawSquare("rojo", casillas[casilla - number]);
                }
                pulsed = false;
                casilla = casillaActual;
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
            casillas[i] = new Casilla
            {
                X = (short)(14 + (i*92) + (i*5)),
                Y = 113,
            };
        }

        //Casillas derecha
        for (int i = 0; i < 7; i++)
        {
            casillas[i+7] = new Casilla
            {
                X = 693,
                Y = (short)(113 + (i) + (i*58)),
            };
        }

        //Casillas abajo
        for (int i = 0; i < 7; i++)
        {
            casillas[i+14] = new Casilla
            {
                X = (short)(693 - (i * 92) - (i * 5)),
                Y = 526,
            };
        }

        //Casillas izquierda
        for (int i = 0; i < 7; i++)
        {
            casillas[i+21] = new Casilla
            {
                X = 14,
                Y = (short)(526 - (i) - (i * 58)),
            };
        }

        casillas[0].categoria = Categoria.Databases;
        casillas[1].categoria = Categoria.Programming;
        casillas[2].categoria = Categoria.Systems;
        casillas[3].categoria = Categoria.Web;
        casillas[4].categoria = Categoria.Databases;
        casillas[5].categoria = Categoria.Programming;
        casillas[6].categoria = Categoria.Systems;
        casillas[7].categoria = Categoria.Web;

        casillas[8].categoria = Categoria.Systems;
        casillas[9].categoria = Categoria.Web;
        casillas[10].categoria = Categoria.Databases;
        casillas[11].categoria = Categoria.Systems;
        casillas[12].categoria = Categoria.Programming;
        casillas[13].categoria = Categoria.Databases;

        casillas[14].categoria = Categoria.Programming;
        casillas[15].categoria = Categoria.Databases;
        casillas[16].categoria = Categoria.Web;
        casillas[17].categoria = Categoria.Programming;
        casillas[18].categoria = Categoria.Databases;
        casillas[19].categoria = Categoria.Systems;
        casillas[20].categoria = Categoria.Web;
        casillas[21].categoria = Categoria.Systems;

        casillas[22].categoria = Categoria.Web;
        casillas[23].categoria = Categoria.Programming;
        casillas[24].categoria = Categoria.Databases;
        casillas[25].categoria = Categoria.Web;
        casillas[26].categoria = Categoria.Systems;
        casillas[27].categoria = Categoria.Programming;
    }

    public void Refresh()
    {
        Hardware.ClearScreen();
        Hardware.DrawImage(tablero);
        Hardware.DrawImage(player);
        Hardware.UpdateScreen();
    }

    private void Move()
    {
        player.MoveTo((short)(casillas[casilla].X - 8), (short)(casillas[casilla].Y - 22));
    }

    private void CrearDado()
    {
        dado = new Image("imgs/dice.png",640,320);
        carasDado = new Sprite[6];

        for (int i = 0; i < 6; i++)
        {
            carasDado[i] = new Sprite((short)((3*i) +(i*104)-i),107, 104, 105);
        }
    }

    private void DrawDado(int number)
    {
        Hardware.DrawSprite(dado, (short)(790 - (carasDado[number].Width)), 2,
                    carasDado[number].X, carasDado[number].Y,
                    carasDado[number].Width, carasDado[number].Height);
        Hardware.UpdateScreen();
    }

    private void DrawSquare(string color, Casilla actual)
    {
        if (color == "verde")
        {
            Hardware.DrawSquare(actual.X, actual.Y, (short)(actual.X+91), (short)(actual.Y+57), 0, 190, 0, 255);
        }
        else if (color == "rojo")
        {
            Hardware.DrawSquare(actual.X, actual.Y, (short)(actual.X + 91), (short)(actual.Y+57), 255, 0, 0, 255);
        }
    }
}
