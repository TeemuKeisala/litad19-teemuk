using System;

namespace if_task2
{
    class Program
    {
        static void Main(string[] args)

        {
            int userInputNumber = 0;
            Console.Write("syötä numero:");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userNumber} on parillinen");
            }
            else
            {
               
                {
                    Console.WriteLine($"Luku {userNumber} on pariton");
                }
            }
        }
    }
}
