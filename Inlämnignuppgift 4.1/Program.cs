using System;

class Program
{
    static void Main()
    {
        for (int i = 200; i >= 180; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        for (int i = 10; i < 31; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        for (int i = 1000; i <= 1400; i += 50)
        {
            Console.WriteLine(i);
        }
    }
}