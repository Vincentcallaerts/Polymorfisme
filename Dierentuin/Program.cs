using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> diertjes = new List<Dier>();

            Schildpad schieldpad = new Schildpad();
            Octopus octopus = new Octopus();
            Ooievaar ooievaar = new Ooievaar();

            schieldpad.Naam = "SchildPad";
            octopus.Naam = "Octopus";
            ooievaar.Naam = "Ooievaar";

            schieldpad.Gewicht = 150;
            octopus.Gewicht = 10;
            ooievaar.Gewicht = 15;

            diertjes.Add(schieldpad);
            diertjes.Add(octopus);
            diertjes.Add(ooievaar);

            bool running = true;
            bool lijstopstellen = true;
            DierenTuin dierenTuin = new DierenTuin();
            

            while (running)
            {
                while (lijstopstellen)
                {
                    switch (SelectMenu("Voeg Dieren Toe aan de DierenTuin",diertjes))
                    {
                        case 0:
                            dierenTuin.AddDier(schieldpad);
                            break;
                        case 1:
                            dierenTuin.AddDier(octopus);
                            break;
                        case 2:
                            dierenTuin.AddDier(ooievaar);
                            break;
                        default:
                            lijstopstellen = false;                           
                            break;
                    }

                }
                switch (SelectMenu("Welkom Bij de Dierentuin","Verwijder dier", "Gemiddelde gewicht dieren", "Dieren Praten", "FilterPraten", "Nieuwe Dierentuin"))
                {

                    case 0:
                        Console.Write("Welke index wilt u verwijderen: ");
                        dierenTuin.DeleteDier(Convert.ToInt32(Console.ReadLine()));

                        break;
                    case 1:
                        dierenTuin.DierenGewichtGemiddelde();
                        Console.ReadKey();
                        break;
                    case 2:
                        dierenTuin.Zegt();
                        Console.ReadKey();
                        break;
                    case 3:
                        dierenTuin.FilterPraat(SelectMenuDier("Welk Dier wilt uw horen", diertjes));
                        Console.ReadKey();
                        break;
                    default:
                        dierenTuin.ClearDiertjes();
                        lijstopstellen = true;
                        break;
                }
            }
        }
        static int SelectMenu(string message, params string[] menu)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
                Console.WriteLine(message);
                for (int i = 0; i < menu.Length; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - menu[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine((i + 1 + ": " + menu[i]));
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection - 1;
        }
        static int SelectMenu(string message, List<Dier> diertjes)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
                Console.WriteLine(message);
                for (int i = 0; i < diertjes.Count; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - diertjes[i].Naam.Length-3) / 2, Console.CursorTop);
                    Console.WriteLine((i + 1 + ": " + diertjes[i].Naam));
                    Console.ResetColor();
                }
                if (selection == 4)
                {
                    Console.ForegroundColor = selectionForeground;
                    Console.BackgroundColor = selectionBackground;
                }
                Console.SetCursorPosition((Console.WindowWidth - 14) / 2, Console.CursorTop);
                Console.WriteLine((4 + ": Stop ingeven"));
                Console.ResetColor();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), diertjes.Count+1);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection - 1;
        }
        static Dier SelectMenuDier(string message, List<Dier> diertjes)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
                Console.WriteLine(message);
                for (int i = 0; i < diertjes.Count; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - diertjes[i].Naam.Length - 3) / 2, Console.CursorTop);
                    Console.WriteLine((i + 1 + ": " + diertjes[i].Naam));
                    Console.ResetColor();
                }
                if (selection == 4)
                {
                    Console.ForegroundColor = selectionForeground;
                    Console.BackgroundColor = selectionBackground;
                }
                Console.SetCursorPosition((Console.WindowWidth - 14) / 2, Console.CursorTop);
                Console.WriteLine((4 + ": Stop ingeven"));
                Console.ResetColor();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), diertjes.Count + 1);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return diertjes[selection - 1];
        }
    }
}
