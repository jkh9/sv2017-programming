using System;

class SocialNetwork
{
    protected byte foundationYear;
    
    public SocialNetwork(string newName, 
        string newUrl, int newFoundationYear)
    {
        Name = newName;
        Url = newUrl;
        FoundationYear = newFoundationYear;
    }

    public string Name { get; set; }
    public string Url { get; set; }
    
    public int FoundationYear
    {
        get { return foundationYear + 1980; }
        set { 
            foundationYear =             
                Convert.ToByte(value - 1980);
            }
    }
}

// --------------------------------

class MyTest
{
    public static void Main()
    {
        SocialNetwork fb = new SocialNetwork(
            "Facebook", "facebook.com", 2004);
        Console.WriteLine(fb.Name + " was founded on "
            + fb.FoundationYear );
    }
}
