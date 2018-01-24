// Moises Encinas

﻿using System;
using System.IO;

﻿abstract class Figura
{
    public float X { get; set; }
    public float Y { get; set; }
    public string Color { get; set; }
    public float Angulo { get; set; }

    public abstract void Dibujar();

    public abstract void RotarAngulo(float newAngulo);

    public abstract void Desplazar(float dx, float dy);

    public abstract void Escalar(float ex, float ey);

    public override string ToString()
    {
        return "Figura en (" + X + "," + Y + ")";
    }

    public virtual string GetInfo()
    {
        return GetType()+" "+X+" "+Y;
    }
}
﻿
// ------------------------------------------------------------------

class Linea : Figura
{
    public float XFinal { get; set; }
    public float YFinal { get; set; }

    public Linea(float X, float Y, float XFinal, float YFinal, string Color)
    {
        this.X = X;
        this.Y = Y;
        this.XFinal = XFinal;
        this.YFinal = YFinal;
        this.Color = Color;
    }

    public override string ToString()
    {
        return base.ToString() +
            ": Línea termina en (" + XFinal + "," + YFinal + ")";
    }

    public override string GetInfo()
    {
        return base.GetInfo() + " " + XFinal + " " + YFinal + " " + Color;
    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }
}
﻿
// ------------------------------------------------------------------

class Elipse : Figura
{
    public float Radio { get; set; }
    public float Radio2 { get; set; }

    public Elipse(float X, float Y, float Radio, float Radio2)
    {
        this.X = X;
        this.Y = Y;
        this.Radio = Radio;
        this.Radio2 = Radio2;
    }

    public override string ToString()
    {
        return base.ToString() +
            ": Elipse con radios(" + Radio + "," + Radio2 + ")";
    }

    public virtual string ToStringBase()
    {
        return base.ToString();
    }
    
    public override string GetInfo()
    {
        return base.GetInfo() + " " + Radio + " " + Radio2;
    }

    public virtual string GetInfoBase()
    {
        return base.GetInfo();
    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }
}

// ------------------------------------------------------------------

class Paralelogramo : Figura
{
    public float XFinal { get; set; }
    public float YFinal { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }

    public override string GetInfo()
    {
        return base.GetInfo();
    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }
}

// ------------------------------------------------------------------

﻿class Cuadrado : Paralelogramo
{
    public float SideSize { get; set; }

    public Cuadrado(float X, float Y, float SideSize)
    {
        this.X = X;
        this.Y = Y;
        this.SideSize = SideSize;
    }

    public override string ToString()
    {
        return base.ToString() +
            ": Cuadrado con " + SideSize + " de tamaño de un lado ";
    }

    public override string GetInfo()
    {
        return base.GetInfo()+" "+SideSize;
    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }

    
}
// ------------------------------------------------------------------

﻿class Rectangulo : Paralelogramo
{
    public Rectangulo(float X, float Y, float XFinal,
            float YFinal, string Color)
    {
        this.X = X;
        this.Y = Y;
        this.XFinal = XFinal;
        this.YFinal = YFinal;
        this.Color = Color;
    }

    public override string ToString()
    {
        return base.ToString() +
            ": Rectangulo termina en (" + XFinal + "," + YFinal + ")";
    }

    public override string GetInfo()
    {
        return base.GetInfo() + " " + XFinal + " " + YFinal + " " + Color;
    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }
}

// ------------------------------------------------------------------

﻿class Polilinea : Figura
{
    public Linea[] Lineas { get; set; }

    public void IncluirSegmento(Linea linea)
    {

    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }
}


// ------------------------------------------------------------------

class Circulo : Elipse
{
    public Circulo(float X, float Y, float Radio) : base(X, Y, Radio, 0)
    {
    }

    public override string ToString()
    {
        return base.ToStringBase() + ": Circulo de radio " + Radio + "\"";
    }

    public override string GetInfo()
    {
        return base.GetInfo() + " " + Radio;
    }

    public override void Dibujar()
    {

    }
    public override void RotarAngulo(float newAngulo)
    {

    }
    public override void Desplazar(float dx, float dy)
    {

    }
    public override void Escalar(float ex, float ey)
    {

    }
}

// ------------------------------------------------------------------


class Dibujo
{
    public Figura[] MiFigura { get; set; }
    public int ArrayCont { get; set; }

    public Dibujo()
    {
        Cargar("figuras.dat");
        MiFigura = new Figura[100];
        ArrayCont = 0;
    }

    public void Incluir(Figura figura)
    {
        MiFigura[ArrayCont] = figura;
        ArrayCont++;
        Guardar("figuras.dat");
    }

    public void Guardar(string fichero)
    {
        // TO DO
    }

    public void Cargar(string fichero)
    {
        // TO DO
    }
}
﻿

class Program
{
    static Dibujo MiDibujo;

    static void Main()
    {
        MiDibujo = new Dibujo();
        bool exit = false;
        do
        {
            ShowMenu();
            string option = Console.ReadLine();
            Console.Clear();
            switch (option)
            {
                case "1":AddLineaORectangulo("linea");break;
                case "2":AddLineaORectangulo("rectangulo");break;
                case "3":AddCuadrado();break;
                case "4":AddElipse();break;
                case "5":AddCirculo();break;
                case "6":ShowMiDibujo(); Console.ReadLine(); break;
                case "0":exit = true; break;
                default:break;
            }
            Console.Clear();
        } while (!exit);
    }

    static void ShowMenu()
    {
        Console.WriteLine("1.-Linea");
        Console.WriteLine("2.-Rectángulo");
        Console.WriteLine("3.-Cuadrado");
        Console.WriteLine("4.-Elipse");
        Console.WriteLine("5.-Circulo");
        Console.WriteLine("6.-Mostrar Dibujo");
        Console.WriteLine("0.-Exit");
    }

    static void AddLineaORectangulo(string tipo)
    {
        Console.Write("x Inicial: ");
        float xInicial = Convert.ToSingle(Console.ReadLine());
        Console.Write("y Inicial:");
        float yInicial = Convert.ToSingle(Console.ReadLine());
        Console.Write("x Final:");
        float xFinal = Convert.ToSingle(Console.ReadLine());
        Console.Write("y Final:");
        float yFinal = Convert.ToSingle(Console.ReadLine());
        Console.Write("Color: ");
        string color = Console.ReadLine();
        if (tipo == "linea")
        {
            MiDibujo.Incluir(new Linea(xInicial,yInicial,xFinal,yFinal, color));
        }
        else
        {
            MiDibujo.Incluir(new Rectangulo(xInicial, yInicial, xFinal, yFinal, color));
        }
        
    }

    static void AddCuadrado()
    {
        Console.Write("X: ");
        float x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Y: ");
        float y = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Size of one side: ");
        float sideSize = Convert.ToSingle(Console.ReadLine());
        MiDibujo.Incluir(new Cuadrado(x,y,sideSize));
    }

    static void AddElipse()
    {
        Console.Write("X: ");
        float x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Y: ");
        float y = Convert.ToSingle(Console.ReadLine());
        Console.Write("Radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        Console.Write("Radius2: ");
        float radius2 = Convert.ToSingle(Console.ReadLine());
        MiDibujo.Incluir(new Elipse(x,y,radius,radius2));
    }

    static void AddCirculo()
    {
        Console.Write("X: ");
        float x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Y: ");
        float y = Convert.ToSingle(Console.ReadLine());
        Console.Write("Radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        MiDibujo.Incluir(new Circulo(x,y,radius));
    }

    static void ShowMiDibujo()
    {
        for (int i = 0; i < MiDibujo.ArrayCont; i++)
        {
            Console.WriteLine(MiDibujo.MiFigura[i].ToString());
        }
    }
}
