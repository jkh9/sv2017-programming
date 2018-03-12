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

//Victor Tebar
using System;
using System.IO;

public class Ejer399{
    public static void Main(string[] args){
        if(args.Length != 1){
            Console.WriteLine("Wrong parametters.");
        }
        else{
            string fileName = args[0];
            if(!File.Exists(fileName)){
                Console.WriteLine("That file doesnt exists");
            }
            else{
                try{
                    BinaryReader readFile = new BinaryReader
                        (File.OpenRead(fileName));
                    bool isPcx = (readFile.ReadByte() == 10);
                    
                    if(isPcx){
                        readFile.ReadByte();
                        bool isCompressed = Convert.ToBoolean(readFile.ReadByte());
                        int colors = (byte)readFile.ReadByte();
                        if(colors == 8){
                            short xMin = readFile.ReadInt16();
                            short yMin = readFile.ReadInt16();
                            short xMax = readFile.ReadInt16();
                            short yMax = readFile.ReadInt16();
                            int width = xMax - xMin + 1;
                            int height = yMax - yMin + 1;
                            
                            readFile.BaseStream.Seek(66,SeekOrigin.Begin);
                            byte realWidth = (byte)readFile.ReadByte();
                            
                            if(width == realWidth){
                                readFile.BaseStream.Seek(128,SeekOrigin.Begin);
                                int count = 0;
                                for(long i=readFile.BaseStream.Position;
                                    i < readFile.BaseStream.Length;i++)
                                {
                                    if(count%width == width - 1)
                                        Console.WriteLine();
                                    count++;
                                    int multiplier = 1;
                                    byte readed = (byte)readFile.ReadByte();
                                    if(readed >= 192){
                                        multiplier = readed - 192;
                                        readed = (byte)readFile.ReadByte();
                                    }
                                    
                                    for(int j=0;j < multiplier;j++){
                                        if(readed >= 0 && readed <= 49){
                                            Console.Write("#");
                                        }
                                        else if(readed >= 50 && readed <= 99){
                                            Console.Write("=");
                                        }
                                        else if(readed >= 100 && readed <= 149){
                                            Console.Write("-");
                                        }
                                        else if(readed >= 150 && readed <= 199){
                                            Console.Write(".");
                                        }
                                        else{
                                            Console.Write(" ");
                                        }
                                    }
                                }
                            }
                            else{
                                Console.WriteLine
                                    ("Can't write the image on console");
                            }
                        }
                        else{
                            Console.WriteLine("Is not a 256 colors image.");
                        }
                    }
                    else{
                        Console.WriteLine("Is not a pcx.");
                    }
                    
                    readFile.Close();
                }
                catch(PathTooLongException){
                    Console.WriteLine("The path is too long");
                }
                catch(IOException e){
                    Console.WriteLine("I/O error: " + e);
                }
                catch(Exception e){
                    Console.WriteLine("Error: " + e);
                }
            }
        }
    }
}
