﻿using System;

namespace kertoma_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define variables.
            int n= 0;
            int fact = 1;

            //Tulostetaan käyttäjälle.
            Console.WriteLine("Kertoman laskenta.");
            Console.Write("Minkä luvun kertoma lasketaan? ");

            //Luetaan käyttäjän syöte ja pakotetaan se interger muotoon.
            n =int.Parse(Console.ReadLine());

            //Ehto, jossa testataan käyttäjän syöttämä arvo.
            //Ohjelman logiikka.
            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte.");
            }

            else


            {
                //Silmukka, jossa lasketaan kertoman arvo.
                while (n > 0)
                {
                    fact = fact * n; //Lasketaan kertoma joka kierroksella.
                    n = n - 1; //Vähennetään arvoa yhdellä.
                }
                //Tulosta vastaus näytölle.
                Console.WriteLine("vastaus:" + fact);
            }
        }
    }
}
