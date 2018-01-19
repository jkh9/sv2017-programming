/*
We want to create a program to keep track of a series of programmable 
electronic devices.

In a first simplistic approach, we will distinguish between "tactile devices" 
and "devices with keyboard". For the first category, we will divide them into 
"smartphones" and "tablets", and for the latter, only as "computers."

We will want to store the processing speed and screen size (diagonal, in 
inches) for each of them. You will have to create the appropriate getters and 
setters, along with a constructor that allows setting the starting values. You 
must also create a "ToString" method, which will return a text such as 
"Smartphone, 800 MHz, 3.2 inches".

In addition, you must create a program that allows the user to enter data of 
devices in any of the three types (in a single array) and to see all the data 
that have been entered.
*/

//Victor Tebar y Pedro Coloma

using System;

public abstract class Device{
    protected double screenSize;
    protected ushort speed;
    
    public double ScreenSize
    {
        get { return screenSize; }
        set { screenSize = value; }
    }
    
    public ushort Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    
    public Device(double screenSize,ushort speed){
        this.screenSize = screenSize;
        this.speed = speed;
    }
}

public abstract class TactileDevices : Device{
    public TactileDevices(double size,ushort speed) : base (size,speed) {}
}

public abstract class KeyboardDevices : Device{
    public KeyboardDevices(double size,ushort speed) : base (size,speed) {}
}

public class Smartphone : TactileDevices{
    public Smartphone(double size,ushort speed) : base (size,speed) {}
    
    public override string ToString(){
        return "Smartphone, " + speed + " MHz, " + screenSize + " inches.";
    }
}

public class Tablet : TactileDevices{
    public Tablet(double size,ushort speed) : base (size,speed) {}
    
    public override string ToString(){
        return "Tablet, " + speed + " MHz, " + screenSize + " inches.";
    }
}

public class Computer : KeyboardDevices{
    public Computer(double size,ushort speed) : base (size,speed) {}
    
    public override string ToString(){
        return "Computer, " + speed + " MHz, " + screenSize + " inches.";
    }
}

public class DevicesTest{
    public static void Main(){
        const int ARRAY_SIZE = 10000;
        Device[] devices = new Device[ARRAY_SIZE];
        int arrayPos = 0;
        string option;
        do{
            Console.WriteLine("1.Add Smartphone.");
            Console.WriteLine("2.Add Tablet.");
            Console.WriteLine("3.Add Computer.");
            Console.WriteLine("4.Show data.");
            Console.WriteLine("x.Exit");
            
            option = Console.ReadLine().ToLower();
            
            switch(option){
                case "1":
                    if(arrayPos < ARRAY_SIZE){
                        Console.WriteLine("Device " + (arrayPos + 1));
                        Console.Write("Enter the screen size: ");
                        double size = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("Enter the speed: ");
                        ushort speed = Convert.ToUInt16(Console.ReadLine());
                        
                        devices[arrayPos] = new Smartphone(size,speed);
                        arrayPos++;
                    }
                    else
                        Console.WriteLine("The database is full");
                    break;
                case "2":
                    if(arrayPos < ARRAY_SIZE){
                        Console.WriteLine("Device " + (arrayPos + 1));
                        Console.Write("Enter the screen size: ");
                        double size = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("Enter the speed: ");
                        ushort speed = Convert.ToUInt16(Console.ReadLine());
                        
                        devices[arrayPos] = new Tablet(size,speed);
                        arrayPos++;
                    }
                    else
                        Console.WriteLine("The database is full");
                    break;
                    
                case "3":
                    if(arrayPos < ARRAY_SIZE){
                        Console.WriteLine("Device " + (arrayPos + 1));
                        Console.Write("Enter the screen size: ");
                        double size = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("Enter the speed: ");
                        ushort speed = Convert.ToUInt16(Console.ReadLine());
                        
                        devices[arrayPos] = new Computer(size,speed);
                        arrayPos++;
                    }
                    else
                        Console.WriteLine("The database is full");
                    break;
                    
                case "4":
                    for(int i=0; i < arrayPos;i++){
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(devices[i]);
                        Console.WriteLine("----------------------------------");
                    }
                    break;
                    
                case "x": Console.WriteLine("Bye");
                    break;
                    
                default: Console.WriteLine("Unknonw option daddy.");
                    break;
            }
        }while(option != "x");
    }
}
