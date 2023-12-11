using System;

internal class Program
{
    private static void Main()
    {
        short x = short.Parse(Console.ReadLine());
        short y = short.Parse(Console.ReadLine());
        short x2 = short.Parse(Console.ReadLine());
        short y2 = short.Parse(Console.ReadLine());
        if (x < 9 && 0 < x && 0 < y && y < 9 && x2 < 9 && 0 < x2 && 0 < y2 && y2 < 9)
        {
            if (x<x2 &&  y==y2 || x == x2 && y < y2 ) 
            { 
                Console.WriteLine(true); 
            }
            else { Console.WriteLine(false); }
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}