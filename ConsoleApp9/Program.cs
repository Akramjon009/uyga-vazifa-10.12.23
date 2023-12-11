Console.WriteLine("X1 ni kiriting ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("X2 ni kiriting ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Y2 ni kiriting  ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Y2 ni kiriting ");
int y2 = int.Parse(Console.ReadLine());

if ((Math.Abs(x - x2) == 2) && (Math.Abs(y - y2) == 1) || (Math.Abs(y - y2) == 1) && (Math.Abs(y - y2) == 2))
{
    Console.WriteLine("Ot bir yurishda bir maydondan ikkinchisiga ota oladi");
}
else
{
    Console.WriteLine("Bu xato yurish!");
}