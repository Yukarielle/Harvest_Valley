using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Inventar : Aktionen
    {
        public void Check_Inventar(Spielstand Spielstand)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                 ╔═══════════════════INVENTAR══════════════════════╗");

            for (int i = 1; i < 5; i++)
            {
                
                Console.WriteLine($"                 ║        Du hast {Spielstand.Anzahl_Inventar[i]} {Spielstand.Inventarfelder[i]}");
                
            }
            Console.WriteLine("                 ║        Du besitzt " + Spielstand.Gold + " Gold");
            Console.WriteLine("                 ╚═════════════════════════════════════════════════╝");

            Console.WriteLine("                                             Inventar verlassen:[X]");
            

            string bla;
            bla = Console.ReadLine().ToLower();
            while (Usereingabe_testen(bla == "x") == false)
            {
            }

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
        }
    }
}
