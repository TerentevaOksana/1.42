using System;
class Programm
{
    static void Main()
    {
        double e, f, g, h, a, b, c;
        Console.WriteLine("Введите значение e:");
        e = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение f:");
        f = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение g:");
        g = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение h:");
        h = int.Parse(Console.ReadLine());
        a = ((e + (f / 2)) / 3);
        b = Math.Abs(Math.Pow(h, 2) - g);
        c = Math.Sqrt(Math.Pow((g - h), 2) - 3 * Math.Sin(e));
        Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);

    }
}