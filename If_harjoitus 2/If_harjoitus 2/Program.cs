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
            else if (x <= 15)
                Console.WriteLine($"Sinun hintasi on {y * 0.5} €");
            else if (x >= 65)
                Console.WriteLine($"Sinun hintasi on {y * 0.5} €");
            else if (x <= 65)
            {
                //Console.WriteLine($"Sinun hintasi on {y} €");


                Console.Write("Oletko varusmies? [K/E]: ");
                string isConscipt = Console.ReadLine().ToUpper();
                if (isConscipt == "K")
                {
                    Console.WriteLine($"Sinun hintasi on {y * 0.5} €");
                }
                else
                {
                    Console.Write("Oletko opiskelija? [K/E]: ");
                    string isStudent = Console.ReadLine().ToUpper();
                    if (isStudent == "K")
                    {
                        Console.Write("Oletko MTK jäsen? [K/E]: ");
                        string isMtkMember = Console.ReadLine().ToUpper();
                        if (isMtkMember == "K")
                        {
                            Console.WriteLine($"Sinun hintasi on {y * 0.45} €");
                        }
                        else
                        {
                            Console.WriteLine($"Sinun hintasi on {y * 0.8} €");
                        }
                    }
                    else
                    {
                        Console.Write("Oletko MTK jäsen? [K/E]: ");
                        string isMtkMember = Console.ReadLine().ToUpper();
                        if (isMtkMember == "K")
                        {
                            Console.WriteLine($"Sinun hintasi on {y * 0.85} €");
                        }
                        else
                        {
                            Console.WriteLine($"Sinun hintasi on {y} €");
                        }

                    }





                }



            }
        }
    }
}
