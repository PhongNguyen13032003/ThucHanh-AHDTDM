using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cac so nguyen co 2 chu so va la boi cua 7:");
        for (int i = 10; i <= 99; i++)
        {
            if (i % 7 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
