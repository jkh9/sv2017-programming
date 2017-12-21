/*
Luis Selles

*/

using System;

class SocialNetwork
{
    protected string name;
    protected string url;
    protected byte yearFoundation;
    
    public SocialNetwork(string setname, 
        string seturl, int setyearFoundation)
    {
        name = setname;
        url = seturl;
        yearFoundation = Convert.ToByte(
            setyearFoundation - 1980);
    }
    
    public string GetName()
    {
        return name;
    }
    
    public void SetName(string setname)
    {
        name = setname;
    }
    
    public string GetUrl()
    {
        return url;
    }
    
    public void SetUrl(string seturl)
    {
        url = seturl;
    }
    
    public int GetYearFoundation()
    {
        return yearFoundation + 1980;
    }
    
    public void SetYearFoundation(int setyear)
    {
        yearFoundation = Convert.ToByte(
            setyear - 1980);
    }
}

class Testing
{
    public static void Main()
    {
        SocialNetwork rs = new SocialNetwork(
            "Facebook", "facebook.com", 2004);
        
        Console.WriteLine("Name: "+rs.GetName()+" Url: "
            +rs.GetUrl()+" Year: "+rs.GetYearFoundation());
    }
}
