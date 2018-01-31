// Ask the user for 5 integer numbers and display
// them reversed, using an ArrayList

// Daniel Miquel Sirera

using System;
using System.Collections;

class Ex331
{
    static void Main(string[] args)
    {
        ArrayList myList = new ArrayList();
        for(int i = 0; i < 5; i++)
        {
            myList.Add( Convert.ToInt32(Console.ReadLine()) );
        }
        
        for(int i = myList.Count-1; i >=0; i--)
        {
            Console.Write(myList[i]+" ");
        }
        Console.WriteLine();
    }
}
