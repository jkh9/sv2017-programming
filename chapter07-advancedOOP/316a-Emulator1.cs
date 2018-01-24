// Moisés Encinas Picazo

class Emuladores
{
    static Computer[] MyComputers = new Computer[50];
    static int ArrayCont = 2;

    static void Main()
    {
        bool exit = false;
        MyComputers[0] = new Computer("ZxSpectrum", 
            new Memory(16384), 
            new ProcesadorZ80(3.5));
        MyComputers[1] = new Computer("Commodore VIC-20", 
            new Memory(5120), 
            new Procesador6502(1.1));
        
        do
        {
            switch (ShowMenuAndReturnOption())
            {
                //Create Z80 Computers
                case "1":
                    AddComputer("Z80");
                    break;
                //Create 6502 Computers
                case "2":
                    AddComputer("6502");
                    break;
                //Show data
                case "3":
                    ShowComputers();
                    break;
                //Exit
                case "0":
                    exit = true;
                    break;
                default:
                    break;
            }
        } while (!exit);
    }

    static string ShowMenuAndReturnOption()
    {
        System.Console.WriteLine("1.- Add a Z80 Computer");
        System.Console.WriteLine("2.- Add a 6502 Computer");
        System.Console.WriteLine("3.- Show Computers");
        System.Console.WriteLine("0.- Exit");
        return System.Console.ReadLine();
    }

    static void AddComputer(string Type)
    {
        if (ArrayCont < 49)
        {
            try
            {
                System.Console.WriteLine("Name: ");
                string name = System.Console.ReadLine();
                System.Console.WriteLine("Memory Size: ");
                int size = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Speed");
                double speed = System.Convert.ToDouble(System.Console.ReadLine());
                if (Type == "Z80")
                {
                    MyComputers[ArrayCont] = new Computer(name, 
                        new Memory(size), new ProcesadorZ80(speed));
                }
                else
                {
                    MyComputers[ArrayCont] = new Computer(name, 
                        new Memory(size), new Procesador6502(speed));
                }
                ArrayCont++;
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("You write something wrong");
                System.Console.WriteLine("Example: Name ZxSpectrum , Size 16384, Speed 3.5 MHz");
            }
        }
        else
        {
            System.Console.WriteLine("Database full!!");
        }
    }

    static void ShowComputers()
    {
        if (ArrayCont > 0)
        {
            for (int i = 0; i < ArrayCont; i++)
            {
                System.Console.WriteLine((i+1)+"-"
                    +MyComputers[i].ToString());
            }
        }
        else
        {
            System.Console.WriteLine("No Data Found");
        }
    }
}

class Computer
{
    public string Name { get;}
    public Memory RAM { get; set; }
    public CPU Cpu { get; set; }

    public Computer(string Name, Memory RAM, CPU Cpu)
    {
        this.Name = Name;
        this.RAM = RAM;
        this.Cpu = Cpu;
    }

    public override string ToString()
    {
        return Name+", procesador "+Cpu.ToString()
            +", "+RAM.Size+ " bytes de memoria";
    }
}

class CPU
{
    public string Registers { get; set; }
    public int Bits { get; set; }
    public double Speed { get; set; }

    public CPU(string Registers, int Bits, double Speed)
    {
        this.Registers = Registers;
        this.Bits = Bits;
        this.Speed = Speed;
    }

    public virtual void AddCommand(int code, string machineCode )
    {
        // ToDo
    }

    public virtual void ShowCommands()
    {
        System.Console.WriteLine("Command list unavailable");
    }

    public override string ToString()
    {
        return Bits+ " bits, "+Speed+" MHz";
    }
}

class Memory
{
    public int Size { get; set; }
    public byte[] bytes;

    public Memory(int Size)
    {
        this.Size = Size;
        bytes = new byte[Size];
    }

    public Memory(int Size, int DataBusSize) : this(Size)
    {
        //TO DO
    }

    public byte Get(int address)
    {
        return bytes[address];
    }

    public void Set(int address, byte valor)
    {
        bytes[address] = valor;
    }
}

class ProcesadorZ80 : CPU
{
    public ProcesadorZ80(double Speed) 
        : base("A B C D E F H L", 8, Speed)
    {
    }
    
    public ProcesadorZ80() 
        : this(4)
    {
    }

    public override void ShowCommands()
    {
        System.Console.Write("Z80: ");
        base.ShowOrders();
    }

    public override string ToString()
    {
        return "Z80, "+base.ToString();
    }
}

class Procesador6502 : CPU
{
    public Procesador6502(double Speed) 
        : base("A X Y", 8, Speed)
    {
    }

    public override void ShowCommands()
    {
        System.Console.Write("6502: ");
        base.ShowOrders();
    }

    public override string ToString()
    {
        return "6502, " + base.ToString();
    }
}
