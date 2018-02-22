//Victor Tebar,Raul Gogna y Javier Herreros.

using System;
using System.IO;

public class Ejer384{
    public static void Main(){
        bool exit = false;
        int height = Console.WindowHeight;
        ConsoleKeyInfo key;
        Console.Write("File name? ");
        string fileName = Console.ReadLine();
        if(!File.Exists(fileName)){
            Console.Write("That file doesnt exist");
        }
        else{
            try{
                int index = 0;
                string[] lines = File.ReadAllLines(fileName);
                Console.Clear();
                do{
                    for(int i=index; i < index + height;i++){
                        Console.WriteLine(lines[i]);
                    }
                    key = Console.ReadKey();
                    switch(key.Key){
                        case ConsoleKey.UpArrow:
                            if(index > 0)
                                index--;
                            break;
                            
                        case ConsoleKey.DownArrow:
                            if(index + height < lines.Length)
                                index++;
                            break;
                            
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                            
                        case ConsoleKey.Home:
                            index = 0;
                            break;
                            
                        case ConsoleKey.PageDown:
                            if(index + height > lines.Length){
                                index += (lines.Length - index);
                            }
                            else
                                index += height;
                            break;
                        case ConsoleKey.PageUp:
                            if(index - height < 0){
                                index -= index;
                            }
                            else
                                index -= height;
                            break;
                            
                        case ConsoleKey.F1:
                            Console.Clear();
                            Console.WriteLine("Move one line up and one " 
                             + "line down using the arrow keys");
                            Console.WriteLine("Move to beginning and the " 
                            + "end of the document using Home, End");
                            Console.WriteLine("Move 24 lines up and down " 
                            + "using Pag.Up y Pag.Down");
                            Console.WriteLine("Show help with F1");
                            Console.WriteLine("Find text with F");
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                            
                    }
                    Console.Clear();
                }while(!exit);
                
                
            }
            catch(PathTooLongException){
                Console.WriteLine("Path too long");
            }
            catch(FileNotFoundException){
                Console.WriteLine("File no accessible");
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
