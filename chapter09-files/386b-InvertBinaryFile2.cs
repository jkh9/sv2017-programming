/*
Create a program to "invert" a file, using a "FileStream": create a file with 
the same name ending in ".inv" and containing the same bytes as the original 
file but in reverse order (the first byte will be the last, the second will be 
the penultimate, and so on, until the last byte of the original file, which 
should appear in the first position of the resulting file).

In this version, you must read the original file one byte at a time, from end 
to beginning.
*/

/*Querubin Santana*/
// Version 2, using a Stack<byte>

using System;
using System.IO;
using System.Collections.Generic;


public class ReadByte
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("file?");
            String filename = Console.ReadLine();

            if(!File.Exists(filename))
            {
                Console.WriteLine("File not found");
            }
            else
            {
                Stack<byte> mystack = new Stack<byte>();
                
                FileStream datainput = File.OpenRead(filename);
                for(int i=0;i<datainput.Length;i++)
                {
                    mystack.Push((byte)datainput.ReadByte()) ;
                }
                datainput.Close();

                FileStream dataoutput = File.OpenWrite(filename+"2"+"txt");
                int amount = myStack.Count;
                for (int i = 0; i < amount; i++)
                {
                    dataoutput.WriteByte(mystack.Pop());
                }
                dataoutput.Close();
            }
        }

    }
