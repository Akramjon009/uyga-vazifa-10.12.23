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
            string resalt = (x + y) % 2 + (x2+y2)%2 == 2 ? "oq" : (x + y) % 2 + (x2 + y2) % 2 == 0? "qora": "false";
            Console.WriteLine(resalt);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}