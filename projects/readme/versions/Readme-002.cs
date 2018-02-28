//Victor Tebar, Gonzalo Martinez y Miguel Garcia
using System;
using System.IO;
using System.Collections.Generic;

public class Readme{
    //Prints the help menu
    public static void PrintHelp(){
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(new string('/',67));
        Console.WriteLine("// Move one line up and one " 
        + "line down using the arrow keys       //");
        Console.WriteLine("// Move to beginning and the " 
        + "end of the document using Home, End //");
        Console.WriteLine("// Move 24 lines up and down " 
        + "using Pag.Up y Pag.Down             //");
        Console.WriteLine("// Show help with F1         "
        + "                                    //");
        Console.WriteLine("// Find text with F          "
        + "                                    //");
        Console.WriteLine("// Press enter to continue.  "
        + "                                    //");
        Console.WriteLine(new string('/',67));
        Console.ResetColor();
    }
    
    //Prints the text
    public static void PrintText(string[] lines,ref int index,ref int height){
        Console.ForegroundColor = ConsoleColor.White;
        for(int i=index; i < index + height;i++){
            Console.WriteLine(lines[i]);
        }
    }
    
    public static void Main(){
        bool exit = false;
        int height = Console.WindowHeight - 2;
        int width = Console.WindowWidth;
        Console.CursorVisible = false;
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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Line: " + index +  "-" + 
                    (index + height) + "/" + lines.Length + 
                    " - Press F1 for help.");
                    Console.ResetColor();
                    PrintText(lines,ref index,ref height);
                    key = Console.ReadKey(true);
                    
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
                            if(index + height < lines.Length - height){
                                index += height; 
                            }
                            else{
                                index += (lines.Length - height - index);
                            }
                                
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
                            PrintHelp();
                            Console.ReadLine();
                            break;
                            
                        //Search function
                        case ConsoleKey.F:{
                            Console.Clear();
                            int foundIndex = 0;
                            List<int> founds = new List<int>();
                            Console.Write("Enter the word: ");
                            string word = Console.ReadLine();
                            //Saves all the index of the words 
                            for(int i=0;i < lines.Length;i++){
                                if(lines[i].Contains(word)){
                                    founds.Add(i);
                                }
                            }
                            if(founds.Count == 0){
                                Console.Clear();
                                Console.WriteLine("Word not found.");
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                            }
                            else{
                                do{
                                    Console.Clear();
                                    index = founds[foundIndex];
                                    if(index + height > lines.Length)
                                        index = lines.Length - height;
                                    PrintText(lines,ref index,ref height);
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Press enter to exit.");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition
                                        (lines[index].IndexOf(word),0);
                                    Console.Write(word);
                                    Console.ResetColor();
                                    key = Console.ReadKey(true);
                                    
                                    switch(key.Key){
                                        case ConsoleKey.UpArrow:
                                            if(foundIndex > 0)
                                                foundIndex--;
                                            break;
                                            
                                        case ConsoleKey.DownArrow:
                                            if(foundIndex < founds.Count - 1)
                                                foundIndex++;
                                            break;
                                    }
                                }while(key.Key != ConsoleKey.Enter);
                            }
                            break;
                        }
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

