## Решење

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Програм за израчунавање полупречника описаног круга правоугаоника.");
        Console.Write("Унесите дужину дијагонале d: ");

        string input = Console.ReadLine();

        if (!double.TryParse(input, out double d) || d <= 0)
        {
            Console.WriteLine("Грешка: потребно је унети позитиван број.");
            return;
        }

        double R = d / 2.0;

        Console.WriteLine($"Полупречник описаног круга R = {R}");
    }
}

