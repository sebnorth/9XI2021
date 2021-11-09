using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteka;
using Stos;

namespace TestStosu
{
    class Program
    {
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tA - Dodaj osobę do stosu");
            Console.WriteLine("\n\t\tB - Usuń osobę ze stosu");
            Console.WriteLine("\n\t\tC - Podaj liczbę osób w stosie");
            Console.WriteLine("\n\t\tD - Wyczyść stos");
            Console.WriteLine("\n\t\tK - Koniec");
            return Console.ReadKey(true).KeyChar;

        }
        static void Main(string[] args)
        {
            Stack mojStos;
            Stack.Create(out mojStos, 10);
            Osoba tmp;
            char c;

            do
            {
                c = Menu();
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Osoba.WprowadzOsobe(out tmp);
                        // Queue.Enqueue(ref mojaKolejka, tmp);
                        Stack.Push(ref mojStos, tmp);
                        break;
                    case 'b':
                    case 'B':
                        // Osoba.WypiszOsobe(Queue.Dequeue(ref mojaKolejka));
                        Console.ReadKey();
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Liczba osób w kolejce wynosi: {0}",
                            Stack.GetLength(mojStos));
                        Console.ReadKey();
                        break;
                    case 'd':
                    case 'D':
                        Stack.Clear(ref mojStos);
                        Console.WriteLine("Kolejka wyczyszczona!!!");
                        Console.ReadKey();
                        break;
                }
            }
            while (!(c == 'k' || c == 'K'));
        }
    }
}
