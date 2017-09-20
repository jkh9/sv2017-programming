/* 
	César Martín Sogorb
	mmHg to Bar
*/

public class Ex020
{
	public static void Main()
	{
		int mmhg;
		int bar;
		
		System.Console.Write("How many mmHg do you want? ");
		mmhg = System.Convert.ToInt32(System.Console.ReadLine());
		
		bar = mmhg * 1000 / 750;
		
		System.Console.Write("The result of bar is ");
		System.Console.WriteLine(bar/1000.0);
	}
}
