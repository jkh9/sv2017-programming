// Victor Tebar, minor corrections by Nacho

using System;

// ------- Device (dispositivo)
public abstract class Device 
{
    protected string name;

    public string Name { set { name = value; } }
}

// ------- SwitchableDevice (dispositivo que se puede encender y apagar)
public abstract class SwitchableDevice : Device
{
    protected bool isOn;

    public bool IsOn() { return isOn; }

    public void TurnOn() { isOn = true; }
    public void TurnOff() { isOn = false; }

    public override string ToString() { return name + ", Switch: " + isOn; }
}

// ------- RollUpDevice (dispositivo enrollable)

public class RollUpDevice : Device
{
    protected int pos;

    public int Pos { get { return pos; } }

    public RollUpDevice(int startingPos)
    {
        Open(startingPos);
    }

    public void Open(int newPos)
    {
        pos = newPos;

        if (pos > 100)
            pos = 100;
        else if (pos < 0)
            pos = 0;
    }

    public void Raise() { pos = 100; }

    public void Lower() { pos = 0; }

    public void Raise(int percentage)
    {
        pos += percentage;
        if (pos > 100)
            pos = 100;
    }

    public void Lower(int percentage)
    {
        pos -= percentage;
        if (pos < 0)
            pos = 0;
    }

    public override string ToString()
    {
        return name + ", Position: " + pos + "%";
    }
}

// ------- Blind (persiana)

public class Blind : RollUpDevice
{
    public Blind(int startingPos)  : base(startingPos) { }
}

// ------- Awning (toldo)

public class Awning : RollUpDevice
{
    public Awning(int startingPos) : base(startingPos) { }
}

// ------- Door (puerta)

public class Door : Device
{
    protected bool locked;

    public bool IsLocked() { return locked; }

    public Door(bool isInitiallyLocked)
    {
        locked = isInitiallyLocked;
    }

    public void Lock()
    {
        locked = true;
    }

    public void Unlock()
    {
        locked = false;
    }

    public override string ToString()
    {
        return name + ", Locked: " + locked;
    }
}

// ------- GarageDoor (puerta del garaje)

public class GarageDoor : Door
{
    protected int pos;

    public GarageDoor(bool isLocked, int pos) : base(isLocked)
    {
        this.pos = pos;

        if (pos > 100)
            pos = 100;
        else if (pos < 0)
            pos = 0;
    }

    public void Raise() { pos = 100; }

    public void Lower() { pos = 0; }

    public void Raise(int percentage)
    {
        pos += percentage;
        if (pos > 100)
            pos = 100;
    }

    public void Lower(int percentage)
    {
        pos -= percentage;
        if (pos < 0)
            pos = 0;
    }

    public override string ToString()
    {
        return base.ToString() + ", Position: " + pos + "%";
    }
}

// ------- Door (ventana)

public class Window : Device
{
    protected Blind blind;

    public Window(Blind blind)
    {
        this.blind = blind;
    }

    public string GetBlind()
    {
        if (blind != null)
            return blind.ToString();
        else
            return "";
    }

    public override string ToString()
    {
        string ret = name;

        if (blind != null)
            ret += ", " + blind.ToString();

        return ret;
    }
}

// ------- HeatableDevice (dispositivo calefactable)

public class HeatableDevice : SwitchableDevice
{
    protected double temperature;

    public double GetTemperature() { return temperature; }

    public HeatableDevice(double temperature) : this(false, temperature) { }

    public HeatableDevice(bool isOn, double temperature)
    {
        this.isOn = isOn;
        this.temperature = temperature;
    }

    public override string ToString()
    {
        return base.ToString() + ", Temperature: " + temperature;
    }
}

// ------- Heating (calefacción)

public class Heating : HeatableDevice
{
    public Heating(bool isOn, double temperature) : base(isOn, temperature) { }
    public Heating(double temperature) : this(false, temperature) { }
}

// ------- Oven (horno)

public class Oven : HeatableDevice
{
    public Oven(bool isOn, sbyte temperature) : base(isOn, temperature) { }
}

// ------- Light (luz)

public class Light : SwitchableDevice
{
    public Light(bool isOn)
    {
        this.isOn = isOn;
    }
}

// ------- RoboticVacuum (aspirador robótico)

public class RoboticVacuum : SwitchableDevice
{
    protected byte batteryPercentage;

    public byte GetBatteryPercentage() { return batteryPercentage; }

    public RoboticVacuum(byte batteryPercentage, bool isOn)
    {
        this.batteryPercentage = batteryPercentage;
        this.isOn = isOn;
    }

    public override string ToString()
    {
        return base.ToString() + ", Battery: " + batteryPercentage + "%";
    }
}

public class DomoticSystem
{
    public static void CreateDevices(Device[] devices)
    {
        for (int i = 0; i < 3; i++)
        {
            devices[i] = new Window(new Blind(50));
            devices[i].Name = "Window " + (i + 1);
        }
        devices[3] = new Door(true);
        devices[3].Name = "Door";

        devices[4] = new GarageDoor(true, 0);
        devices[4].Name = "Garage door";

        devices[5] = new Light(false);
        devices[5].Name = "Light";

        devices[6] = new Heating(true, 20);
        devices[6].Name = "Heating 1";

        devices[7] = new Heating(true, 20);
        devices[7].Name = "Heating 2";
    }

    public static void Main()
    {
        Device[] devices = new Device[8];
        CreateDevices(devices);

        string option;

        do
        {
            Console.WriteLine("1.Lock/Unlock door");
            Console.WriteLine("2.Turn on/off light");
            Console.WriteLine("3.Rise garage door.");
            Console.WriteLine("4.Lower garage door.");
            Console.WriteLine("7.Show status.");
            Console.WriteLine("x.Exit.");

            option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "1":
                    if (((Door)devices[3]).IsLocked())
                        ((Door)devices[3]).Unlock();
                    else
                        ((Door) devices[3]).Lock();
                    break;

                case "2":
                    if (((Light)devices[5]).IsOn())
                        ((Light)devices[5]).TurnOn();
                    else
                        ((Light)devices[5]).TurnOff();
                    break;

                case "3":
                    ((GarageDoor)devices[4]).Raise();
                    break;

                case "4":
                    ((GarageDoor)devices[4]).Lower();
                    break;

                case "7":
                    foreach (Device d in devices)
                        Console.WriteLine(d);
                    break;

                case "x":
                    Console.WriteLine("Bye.");
                    break;

                default:
                    Console.WriteLine("Unknown option");
                    break;
            }

        } while (option != "x");
    }
}
