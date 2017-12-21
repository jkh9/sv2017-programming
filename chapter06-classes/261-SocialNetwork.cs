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

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetUrl(string newUrl)
    {
        name = newUrl;
    }

    public string GetUrl()
    {
        return url;
    }

    public void SetFoundationYear (int newFoundationYear)
    {
        foundationYear = newFoundationYear;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }
}

// --------------------------------

class MyTest
{
    public static void Main()
    {
        SocialNetwork fb = new SocialNetwork(
            "Facebook", "facebook.com", 2004);
        Console.WriteLine(fb.GetName() + " was founded on "
            + fb.GetFoundationYear() );
    }
}
