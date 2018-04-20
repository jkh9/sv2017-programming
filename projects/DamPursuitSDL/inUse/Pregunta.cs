using System;
using System.Collections.Generic;
using System.IO;

public enum Categoria
{
    Programming,Databases,Systems,Web
}
public class Pregunta
{
    public string Enunciado { get; set; }
    public Categoria Categoria { get; set; }
    public string[] Respuestas { get; set; }
    public int RespuestaCorrecta { get; set; }

    public Pregunta()
    {
        Respuestas = new string[4];
    }

    public static List<Pregunta> LoadPreguntas()
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        if (!File.Exists("questions\\questions.txt"))
        {
        }
        else
        {
            try
            {
                StreamReader input = new StreamReader("questions\\questions.txt");
                string line;

                do
                {
                    line = input.ReadLine();
                    if (line != null)
                    {
                        Pregunta PreguntaActual = new Pregunta();
                        PreguntaActual.Enunciado = line;
                        string categoria = input.ReadLine();
                        switch (categoria)
                        {
                            case "Programming":
                                PreguntaActual.Categoria = Categoria.Programming;
                                break;
                            case "Databases":
                                PreguntaActual.Categoria = Categoria.Databases;
                                break;
                            case "Systems":
                                PreguntaActual.Categoria = Categoria.Systems;
                                break;
                            case "Web":
                                PreguntaActual.Categoria = Categoria.Web;
                                break;
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            PreguntaActual.Respuestas[i] = input.ReadLine().Substring(1);
                        }
                        PreguntaActual.RespuestaCorrecta = Convert.ToInt32(input.ReadLine());
                        preguntas.Add(PreguntaActual);
                    }
                } while (line != null);
                input.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
        return preguntas;
    }

    public static void SavePreguntas(List<Pregunta> preguntas)
    {
        try
        {
            StreamWriter output = new StreamWriter("Preguntas\\preguntas.txt");
            for (int i = 0; i < preguntas.Count; i++)
            {
                output.WriteLine(preguntas[i].Enunciado);
                output.WriteLine(preguntas[i].Categoria);
                for (int j = 0; j < 4; j++)
                {
                    output.WriteLine("-"+preguntas[i].Respuestas[j]);
                }
                output.WriteLine(preguntas[i].RespuestaCorrecta);
            }
            output.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
