using System;

namespace if_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää käyttäjän syöttämästä luvusta, onko se positiivinen vai negatiivinen");
            Console.Write("syötä kokonaisluku:");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine($"Luku {userNumber}on positiivinen");
            }
            else
            {
                if (userNumber > 0)
                {
                    Console.WriteLine($"Luku {userNumber}on negatiivinen");
                }
            }
            }
        }
    }

