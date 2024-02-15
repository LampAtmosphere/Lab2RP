using System;

public class Tablitsa_umnozhenia_csharp
{
    public static void Main()
    {
        Console.WriteLine("Таблица умножения");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(i * j + "\t");
            }
        }
    }
}