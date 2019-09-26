using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample"); //Tulostaa näytölle viestin""
            Console.Write("Moi, kirjoita nimesi: ");//Tulostaa näytölle viestin"" mutta jättää kursorin samalle riville kuin tekstin
            string userInput = Console.ReadLine(); // Lukee käyttäjän kirjoittaman viestin.
            Console.WriteLine("-----");
            Console.WriteLine("Moi" + userInput + "!"); //Vaihtoehto 1
            Console.WriteLine("Moi {0}!", userInput); //Vaihtoehto 2
            Console.WriteLine($"Moi {userInput}!"); //Vaihtoehto 3
            //Tulostuksen muotoilu ja muuttujien käyttö 
            //tulostuksen yhdteydessä $-merkin avulla = string.Format()

        }
    }
}
