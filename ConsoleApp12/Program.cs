using System;

class Program
{
    static void Main()
    {
        Console.Write("nechta son bolishini kiriting: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Malumotni kiriting: ");
        string[] input = Console.ReadLine().Split(',');

        int[] malumot = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            malumot[i] = Convert.ToInt32(input[i]);
        }

        bool natija = JuftYoqmi(n, malumot);

        if (natija)
        {
            Console.WriteLine($"{string.Join(", ", malumot)} dagi sonlar ichida toq son juft sonlardan biri yo'q.");
        }
        else
        {
            Console.WriteLine($"{string.Join(", ", malumot)} dagi sonlar ichida toq sonlardan biri bor.");
        }
    }

    static bool JuftYoqmi(int n, int[] malumot)
    {
        int aloeNur = 0;
        foreach (int son in malumot)
        {
            aloeNur ^= son;
        }
        return aloeNur % 2 == 1;
    }
}
