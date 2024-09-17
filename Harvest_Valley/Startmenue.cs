using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Startmenue
    {
        

        public void MenueAuswahl(Dialoge dialog)
        {
            
            bool Hauptmenue = true;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            

            do
            {
                Console.Clear();
                Console.WriteLine("\t   _   _                           _     _   _       _ _            ");
                Console.WriteLine("\t  | | | |                         | |   | | | |     | | |           ");
                Console.WriteLine("\t  | |_| | __ _ _ ____   _____  ___| |_  | | | | __ _| | | ___ _   _ ");
                Console.WriteLine("\t  |  _  |/ _` | '__\\ \\ / / _ \\/ __| __| | | | |/ _` | | |/ _ \\ | | |");
                Console.WriteLine("\t  | | | | (_| | |   \\ V /  __/\\__ \\ |_  \\ \\_/ / (_| | | |  __/ |_| |");
                Console.WriteLine("\t  \\_| |_/\\__,_|_|    \\_/ \\___||___/\\__|  \\___/ \\__,_|_|_|\\___|\\__, |");
                Console.WriteLine("\t                                                               __/ |");
                Console.WriteLine("\t                                                              |___/ ");

                Console.WriteLine();
                Console.WriteLine("\t\t\t\t[1]Spiel starten");
                Console.WriteLine("\t\t\t\t  [2]Beenden");
                Console.WriteLine();
                Console.WriteLine("\t\t\tBitte auswählen und Enter drücken:");
                Console.Write("\t\t\t\t\t");
                string auswahl = Console.ReadLine();

                if (auswahl == "1")
                {
                    
                    dialog.Begrueßung();
                    Hauptmenue = false;
                }
                else if (auswahl == "2")
                {
                    Console.WriteLine("\t\t\tDu hast die Anwendung beendet. Bis zum nächsten mal!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\t\t\t\tFalsche Eingabe.");
                    Thread.Sleep(1000);
                }
            } while (Hauptmenue == true);

        }



        
    }
}
