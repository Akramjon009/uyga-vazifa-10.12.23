using System;

internal class Program
{
    private static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x < 9 && 0<x && 0 <y && y < 9)
        {

            string resalt = (x + y) % 2 == 1 ? "oq" : "qora";
            Console.WriteLine(resalt);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}