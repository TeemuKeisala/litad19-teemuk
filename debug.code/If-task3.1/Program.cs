using System;

namespace If_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolven luvun lajittelu!");
            //Tietojen kysely
            Console.Write("Syötä 1. luku; ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä 2. luku; ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Syötä 3. luku; ");
            int z = int.Parse(Console.ReadLine());
            //Logiikka, jolla ratkaistaan ongelma.
            if (x < y)
            {
                if (x < y && y < z)
                {
                    Console.WriteLine($"{x} <{y} < {z}");
                }
                if (z < y && y < x)
                {
                    Console.WriteLine($"{z} <{y} < {x}");
                }
                if (z < x && x < y)
                {
                    Console.WriteLine($"{z} <{x} < {y}");
                }
                if (x < z && z < y)
                {
                    Console.WriteLine($"{x} <{z} < {y}");
                }
                if (y < x && x < z)
                {
                    Console.WriteLine($"{y} <{x} < {z}");
                }
                if (y < z && z < x)
                {
                    Console.WriteLine($"{y} <{z} < {x}");
                }
            }
            //Tulostetaan vastaus
        }
    }
}
