using System;

class Program
{
    static void Main()
    {
        Console.Write("a ni kiriting: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b ni kiriting: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c ni kiriting: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant >= 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else
        {
            Console.WriteLine(false);
        }

            }
    }