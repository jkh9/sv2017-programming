using System;

class SocialNetwork
{
    protected string name;
    protected string url;
    protected int foundationYear;

    public SocialNetwork(string newName, 
        string newUrl, int newFoundationYear)
    {
        name = newName;
        url = newUrl;
        foundationYear = newFoundationYear;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public string Url
    {
        get { return url; }
        set { url = value; }
    }
    
    public int FoundationYear
    {
        get { return foundationYear; }
        set { foundationYear = value; }
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
