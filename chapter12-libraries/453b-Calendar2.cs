//
//Miguel Puerta

using System;

public class myCs
{
    static void DibujarMes(string mesAno)
    {
        int diaS, pos = 0, dia, mesD = 0, ano = 0, diasM = 0, j = 0;
        string mes;
        string[] mesyAno = new string[2];
        char d = ' ';

        if (mesAno != "actual")
        {
            mesyAno = mesAno.Split(d);

            mes = mesyAno[0];
            mes = mes.ToLower();

            if (mesAno.IndexOf(" ") < 0)
            {
                mes = "fake";
            }
            else
            {
                ano = Convert.ToInt32(mesyAno[1]);
            }
        }
        else
        {
            mes = mesAno;
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;

        switch (mes)
        {
            case "enero": mesD = 1;
                break;
            case "febrero": mesD = 2;
                break;
            case "marzo": mesD = 3;
                break;
            case "abril": mesD = 4;
                break;
            case "mayo": mesD = 5;
                break;
            case "junio": mesD = 6;
                break;
            case "julio": mesD = 7;
                break;
            case "agosto": mesD = 8;
                break;
            case "septiembre": mesD = 9;
                break;
            case "octubre": mesD = 10;
                break;
            case "noviembre": mesD = 11;
                break;
            case "diciembre": mesD = 12;
                break;
            case "actual":

                DateTime FActual = DateTime.Today;
                dia = FActual.Day;
                mesD = FActual.Month;
                ano = FActual.Year;
                diaS = (int)FActual.DayOfWeek;

                break;
            default: Console.WriteLine("Te has equivocao macho!");
                break;
        }

        switch (mesD)
        {
            case 1: Console.WriteLine("\n      Enero {0}", ano);
                diasM = 31;
                break;
            case 2: Console.WriteLine("\n     Febrero {0}", ano);
                if (ano % 4 != 0)
                {
                    diasM = 28;
                }
                else
                {
                    diasM = 29;
                }

                break;
            case 3: Console.WriteLine("\n      Marzo {0}", ano);
                diasM = 31;
                break;
            case 4: Console.WriteLine("\n      Abril {0}", ano);
                diasM = 30;
                break;
            case 5: Console.WriteLine("\n       Mayo {0}", ano);
                diasM = 31;
                break;
            case 6: Console.WriteLine("\n      Junio {0}", ano);
                diasM = 30;
                break;
            case 7: Console.WriteLine("\n      Julio {0}", ano);
                diasM = 31;
                break;
            case 8: Console.WriteLine("\n      Agosto {0}", ano);
                diasM = 31;
                break;
            case 9: Console.WriteLine("\n    Septiembre {0}", ano);
                diasM = 30;
                break;
            case 10: Console.WriteLine("\n     Octubre {0}", ano);
                diasM = 31;
                break;
            case 11: Console.WriteLine("\n     Noviembre {0}", ano);
                diasM = 30;
                break;
            case 12: Console.WriteLine("\n     Diciembre {0}", ano);
                diasM = 31;
                break;
            default:
                break;
        }
        Console.WriteLine();

        if (mes != "fake")
        {
            Console.WriteLine("  L  M  X  J  V  S  D");
        }

        for (int i = 0; i < diasM; i++)
        {
            DateTime dia1 = new DateTime(ano, mesD, i + 1);

            switch ((int)dia1.DayOfWeek)
            {
                case 0: pos = 6;
                    break;
                case 1: pos = 0;
                    break;
                case 2: pos = 1;
                    break;
                case 3: pos = 2;
                    break;
                case 4: pos = 3;
                    break;
                case 5: pos = 4;
                    break;
                case 6: pos = 5;
                    break;
                default:
                    break;
            }

            switch (pos)
            {
                case 0: Console.SetCursorPosition(0, 8 + j);
                    break;
                case 1: Console.SetCursorPosition(3, 8 + j);
                    break;
                case 2: Console.SetCursorPosition(6, 8 + j);
                    break;
                case 3: Console.SetCursorPosition(9, 8 + j);
                    break;
                case 4: Console.SetCursorPosition(12, 8 + j);
                    break;
                case 5: Console.SetCursorPosition(15, 8 + j);
                    break;
                case 6: Console.SetCursorPosition(18, 8 + j);
                    break;
                default:
                    break;
            }

            if (pos == 6)
            {
                j = j + 1;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else
            {
                if (pos == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            if (i < 9)
            {
                Console.Write("  {0}", i + 1);
            }
            else
            {
                Console.Write(" {0}", i + 1);
            }
        }
    }
        
    public static void Main()
    {
        Console.Write("\n Introduzca mes (espacio) y año (ej: \"abril 2018\"): ");
        string mesCal = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("=====================");
        Console.WriteLine("*    Calendario     *");
        Console.WriteLine("=====================");
        DibujarMes(mesCal);

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("\n\nPulse cualquier \ntecla para continuar");
        Console.ReadKey();
    }
}
