using System;

class Program
{
    static void Main()
    {
        Console.Write("Kun = ");
        int day = Convert.ToInt16(Console.ReadLine());
        Console.Write("Oy = ");
        int month = Convert.ToInt16(Console.ReadLine());

        if (month <= 1 || month >= 12 || day <= 1 || day >= 31)
        {
            if (month == 1 && day >= 20 || month == 2 && day <= 18) Console.WriteLine("Qovg'a");
            else if (month == 2 && day >= 19 || month == 3 && day <= 20) Console.WriteLine("Baliq");
            else if (month == 3 && day >= 21 || month == 4 && day <= 19) Console.WriteLine("Qo'y");
            else if (month == 4 && day >= 20 || month == 5 && day <= 20) Console.WriteLine("Buzoq");
            else if (month == 5 && day >= 21 || month == 6 && day <= 21) Console.WriteLine("Egizak");
            else if (month == 6 && day >= 22 || month == 7 && day <= 22) Console.WriteLine("Qisqichbaqa");
            else if (month == 7 && day >= 23 || month == 8 && day <= 22) Console.WriteLine("Arslon");
            else if (month == 8 && day >= 23 || month == 9 && day <= 22) Console.WriteLine("Parizod");
            else if (month == 9 && day >= 23 || month == 10 && day <= 22) Console.WriteLine("Tarozi");
            else if (month == 10 && day >= 23 || month == 11 && day <= 22) Console.WriteLine("Chayon");
            else if (month == 11 && day >= 23 || month == 12 && day <= 21) Console.WriteLine("O'q otar");
            else if (month == 12 && day >= 22 || month == 1 && day <= 19) Console.WriteLine("Echki");
            else Console.WriteLine("Error! ");
        }
        else
        {
            Console.WriteLine("Noto'g'ri kiritilgan sanalar. Iltimos, qayta kiriting.");
        }
    }
}