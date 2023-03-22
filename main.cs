using System;
using System.Linq;
using System.Diagnostics;

namespace HaziFeldatwo
{
    public static class Program
    {
        public static void Main()
        {
            Random rnd = new Random();
            int szam;
            bool TP = true;
            int x;
            int y;
            int atlagResz = 0;
            Console.Write("Kérem adjon meg egy pozitív számot: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out szam) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nem számot adtál meg.");
                    Console.ResetColor();
                    Console.Write("Kérlek probáld újra: ");
                }
                else
                {
                        /*if (szam%2 != 0)
                        {
                            Console.WriteLine("A szám amit megadtál nem páros.");
                            Console.Write("Kérlek probáld újra: ");
                        }
                        else */if (szam < 2)
                        {
                            TP = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A szám amit megadtál minimum 2 kell, hogy legyen.");
                            Console.ResetColor();
                            Console.Write("Kérlek probáld újra: ");
                        }
                }
            }while (/*szam%2 != 0 || */TP == false && int.TryParse(Console.ReadLine(), out szam));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Szuper.");
            Console.ResetColor();
            int[] tomb = new int[szam];
            Console.Write("Kérem adjon meg egy (x) számot: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out x) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nem számot adtál meg.");
                    Console.ResetColor();
                    Console.Write("Kérlek probáld újra: ");
                }
            }while (int.TryParse(Console.ReadLine(), out x) == false);
            Console.Write("Kérem adjon meg egy (x)-nél nagyobb (y) számot: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out y) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nem számot adtál meg.");
                    Console.ResetColor();
                    Console.Write("Kérlek probáld újra: ");
                }
                else
                {
                        if (x >= y)
                        {
                            TP = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A szám amit megadtál (y)-nak, kisebb vagy egyenlő (x)-el.");
                            Console.ResetColor();
                            Console.Write("Kérlek probáld újra: ");
                        }
                }
            }while (TP == false);
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(x,y+1);
                Debug.WriteLine(tomb[i]);
                atlagResz += tomb[i];
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("A tömb számainak átlaga: {0}",atlagResz/szam);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
