using System;
public static class DecimalToBinary
{
    static void Main() 
    {
        string returnString = "10";
        long current = long.Parse(returnString);
        string binString = System.Convert.ToString(current, 2);
        System.Console.WriteLine(binString);
    }
}