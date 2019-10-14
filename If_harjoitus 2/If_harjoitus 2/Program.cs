using System;

namespace If_harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 16;
           
            Console.WriteLine("Syötä ikäsi.");
            int x = int.Parse(Console.ReadLine());
            if (x <= 7)
                Console.WriteLine("Ilmainen");
            if (x <= 15)
                Console.WriteLine($"Sinun hintasi on {y*0.5} €");
            if (x >= 65)
                Console.WriteLine($"Sinun hintasi on {y * 0.5} €");
            else if (x <= 65)
                Console.WriteLine($"Sinun hintasi on {y} €");

            Console.WriteLine("Oletko varusmies?");
            if userInput = ("kyllä");
                Console.WriteLine($"Sinun hintasi on {y * 0.5} €");
            if userInput = ("ei")
            Console.WriteLine("Oletko opiskelija?");
            Console.WriteLine("Oletko MTK jäsen?");


        }
    }
}
