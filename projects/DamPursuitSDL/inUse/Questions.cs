using System;
using System.Collections.Generic;
using System.IO;
using Tao.Sdl;

public enum Category
{
    Programming,Databases,Systems,Web
}
public class Question
{
    public string Statement { get; set; }
    public Category Category { get; set; }
    public string[] Answers { get; set; }
    public int CorrectAnswer { get; set; }

    public Question()
    {
        Answers = new string[4];
    }

    public static List<Question> LoadQuestions()
    {
        List<Question> questions = new List<Question>();
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
                        Question ActualQuestion = new Question();
                        ActualQuestion.Statement = line;
                        string categoria = input.ReadLine();
                        switch (categoria)
                        {
                            case "Programming":
                                ActualQuestion.Category = Category.Programming;
                                break;
                            case "Databases":
                                ActualQuestion.Category = Category.Databases;
                                break;
                            case "Systems":
                                ActualQuestion.Category = Category.Systems;
                                break;
                            case "Web":
                                ActualQuestion.Category = Category.Web;
                                break;
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            ActualQuestion.Answers[i] = input.ReadLine().Substring(1);
                        }
                        ActualQuestion.CorrectAnswer = Convert.ToInt32(input.ReadLine());
                        questions.Add(ActualQuestion);
                    }
                } while (line != null);
                input.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
        return questions;
    }

    public void Display(Font font)
    {
        Sdl.SDL_Color statementColor = new Sdl.SDL_Color(0xff, 0x00, 0x00);
        Sdl.SDL_Color answerColors = new Sdl.SDL_Color(0x00,0xff,0x00);

        IntPtr statementImg = 
            SdlTtf.TTF_RenderText_Solid(font.GetFontType(),Statement, statementColor);
        IntPtr[] answersImg = new IntPtr[4];

        for(int i=0;i < answersImg.Length; i++)
        {
            answersImg[i] =
                SdlTtf.TTF_RenderText_Solid(font.GetFontType(), Answers[i], statementColor);
        }
    }

    public static void SaveQuestions(List<Question> questions)
    {
        try
        {
            StreamWriter output = new StreamWriter("Preguntas\\preguntas.txt");
            for (int i = 0; i < questions.Count; i++)
            {
                output.WriteLine(questions[i].Statement);
                output.WriteLine(questions[i].Category);
                for (int j = 0; j < 4; j++)
                {
                    output.WriteLine("-"+questions[i].Answers[j]);
                }
                output.WriteLine(questions[i].CorrectAnswer);
            }
            output.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
