/*
Exam of 2012-2013: PCX Viewer

El formato PCX permite guardar imágenes con una compresión moderada. Deberás 
mostrar en pantalla (consola) el contenido de un fichero PCX de pequeño tamaño. 
Los pasos que deberás seguir son:

- Comprobar si el primer byte (el byte 0) es 10 (la marca que indica que se 
  trata de un PCX). Si no es así, el programa deberá salir con un mensaje de 
  error adecuado.

- Comprobar si el byte 2 (compresión) es 1, que indicaría imagen comprimida, o 
  0, que indicaría una imagen sin comprimir.

- Comprobar si el byte 3 (bits por píxel) es 8, que indicaría que es una imagen 
  de 256 colores. Si no es 8, el programa deberá salir con un mensaje de error 
  adecuado.

- A partir de la posición 4, hay 4 enteros cortos: xMin, yMin, xMax, yMax, que 
  sirven para calcular el ancho y el alto.

- En la posición 66 hay un byte que indica la cantidad de bytes que formarán 
  cada línea de la imagen. Debería coincidir con el ancho de la imagen; si no 
  es así, el programa deberá salir con un mensaje de error adecuado.

- En la posición 128 empiezan los datos de la imagen, con compresión RLE (Run 
  Length Encoding). El formato de compresión es el siguiente:

  Se debe leer un byte "n"

  Si los dos bits más significativos de ese byte son 0 (es, decir, si "n" es 
  menor que 192), quiere decir que se trata de un dato no comprimido, y se 
  puede "mostrar" ese dato en pantalla (de la forma que se detalla más 
  adelante).

  Si los dos bits más significativos de ese byte son 1 (es, decir, si "n" es 
  mayor o igual que 192), quiere decir que se trata de un dato comprimido, y en 
  ese caso:

        La cantidad de veces que se debe repetir viene dada por los 6 bits 
        menos significativos de "n" (es decir, hay que repetir tantas veces 
        como indique "n-192")

        El siguiente byte que se lea de fichero es el dato que se debe 
        "mostrar" repetido esas "n-192" veces.

- La forma de "mostrar" esos puntos será suponiendo que la imagen es de tonos 
  de gris, y dibujando un carácter más o menos "denso", que imite esa 
  tonalidad:

    - Si la intensidad de gris es mayor de 200, dibujarás un espacio en blanco.
    - Si está entre 150 y 199, dibujarás un punto.
    - Si está entre 100 y 149, dibujarás un guión (-).
    - Si está entre 50 y 99, dibujarás un símbolo de "igual" (=).
    - Si está entre 0 y 49, dibujarás una almohadilla (#).

El nombre del fichero a analizar se debe leer desde la línea de comandos, no 
preguntar al usuario ni estar prefijado.
*/

// Javier Saorín Vidal

using System;
using System.IO;

class PCXExamTest
{
    public static int Main(string[] args)
    {
        if (args.Length <= 0)
        {
            return 1;
        }

        if (!File.Exists(args[0]))
        {
            Console.WriteLine(args[0] + " is not a valid file name!");
            return 2;
        }
        else
        {
            try
            {
                BinaryReader input =
                    new BinaryReader(File.Open(args[0], FileMode.Open));

                bool compressed = false;

                byte b1 = input.ReadByte();
                if (b1 != 10)
                {
                    Console.WriteLine("Not a valid PCX");
                    return 3;
                }

                byte b2 = input.ReadByte();
                if (b2 != 0)
                {
                    Console.WriteLine("The file is compressed.");
                    compressed = true;
                }

                byte b3 = input.ReadByte();
                if (b3 != 8)
                {
                    Console.WriteLine("Not a 256 color image.");
                    return 5;
                }

                short xMin = input.ReadInt16();
                short yMin = input.ReadInt16();
                short xMax = input.ReadInt16();
                short yMax = input.ReadInt16();

                int width = xMax - xMax + 1;
                int height = yMax - yMin + 1;

                Console.WriteLine("Width: " + width);
                Console.WriteLine("Height: " + height);

                input.BaseStream.Seek(66, SeekOrigin.Begin);
                short lineBytes = input.ReadInt16();

                Console.WriteLine("Bytes per Line: " + lineBytes);

                if (lineBytes != width || width > 255)
                {
                    Console.WriteLine("Error, width not match with the bytes per line");
                    return 6;
                }

                input.BaseStream.Seek(128, SeekOrigin.Begin);
                byte n = input.ReadByte();

                for (int row = 0; row < height; row++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        int repeatTimes;
                        if (n < 192)
                            repeatTimes = 1;
                        else
                            repeatTimes = n - 192;
   
                        byte b = input.ReadByte();
                        for (int col = 0; col < repeatTimes; col++)
                        {
                            if (b > 200)
                            {
                                Console.Write(" ");
                            }
                            else if (b >= 150 && b <= 199)
                            {
                                Console.Write(".");
                            }
                            else if (b >= 100 && b <= 149)
                            {
                                Console.Write("-");
                            }
                            else if (b >= 50 && b <= 99)
                            {
                                Console.Write("=");
                            }
                            else
                            {
                                Console.Write("#");
                            }
                        }
                    }
                    Console.WriteLine();
                }
               


                input.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("PATH TOO LONG: ");
            }
            catch (IOException e)
            {
                Console.WriteLine("INPUT/OUTPUT ERROR: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }

            return 0;
        }
    }
}
