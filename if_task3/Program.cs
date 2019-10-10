using System;

namespace if_task3
{
    class Program
    {
        static void Main(string[] args)

        {
            int userInputNumber = 0;
            Console.Write("syötä numero:");
            userInputNumber = int.Parse(Console.ReadLine());
            if (userInputNumber == 0)
            {
                Console.WriteLine($"luku on nolla");
            }


            if (userInputNumber < 0 && userInputNumber % 2 == 0)
            {
                Console.WriteLine($"luku on negatiivinen sekä parillinen");
            }
            if (userInputNumber > 0 && userInputNumber % 2 == 0)
            {
                Console.WriteLine($"luku on positiivinen sekä parillinen");
            }
            if (userInputNumber < 0 && userInputNumber % 2 == 1)
            {
                Console.WriteLine($"luku on negatiivinen sekä pariton");
            }
            if (userInputNumber > 0 && userInputNumber % 2 == 1)
            {
                Console.WriteLine($"luku on positiivinen sekä pariton");
            }
        }
    }
}
    


