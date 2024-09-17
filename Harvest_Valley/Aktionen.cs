using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Aktionen
    {
        public int Eingabe;
       
        
        public int Spielmenues(string menue)
        {
            switch (menue)
            {
                case "Weg":
                    Console.WriteLine("Was möchtest du als nächstes tun?");
                    Console.WriteLine();
                    Console.WriteLine("[1]Feld (um Pflanzen kümmern)");
                    Console.WriteLine("[2]Marktplatz (Einkaufen)");
                    Console.WriteLine("[3]Inventar anzeigen");
                    Console.WriteLine("[4]Schlafen (Nächsten Tag anbrechen)");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                        while (Usereingabe_testen(Eingabe == 1 || Eingabe == 2 || Eingabe == 3 || Eingabe == 4) == false)
                        {

                        }
                        return Eingabe;
                case "Shop_Einkaufen":
                    Shop shop = new Shop();
                    shop.Inventar_Shop();

                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    Console.WriteLine("═══════════════════════════MARKTPLATZ══════════════════════════════════");
                    Console.WriteLine("Willkommen auf dem Marktplatz! Was möchstest du kaufen?");
                    Console.WriteLine();
                    Console.WriteLine($"[1] {shop.Shop_Inventar[1]} \tKosten: {shop.Shop_Kosten[1]} Gold");
                    Console.WriteLine($"[2] {shop.Shop_Inventar[2]} \tKosten: {shop.Shop_Kosten[2]} Gold");
                    Console.WriteLine($"[3] {shop.Shop_Inventar[3]} \tKosten: {shop.Shop_Kosten[3]} Gold");
                    Console.WriteLine($"[4] {shop.Shop_Inventar[4]} \t\tKosten: {shop.Shop_Kosten[4]} Gold");
                    Console.WriteLine("[5] Shop verlassen."); //<--soll case "Weg" triggern
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe == 1 || Eingabe == 2 || Eingabe == 3 || Eingabe == 4 || Eingabe == 5) == false)
                    {

                    }
                    return Eingabe;

                case "Shop_Anzahl":
                    Console.WriteLine("Wie viele hättest du gern? (max. 20)");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe < 20) == false)
                    {

                    }
                    return Eingabe;

                case "Shop_Verlassen":
                    Console.WriteLine("Möchtest du weiter einkaufen?");
                    Console.WriteLine("[1] Ja");
                    Console.WriteLine("[2] Nein"); //<-soll auch Case "Weg" triggern.
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe == 1 || Eingabe == 2) == false)
                    {

                    }
                    return Eingabe;

                case "Feld":

                    Console.WriteLine("Was möchtest du tun?");
                    Console.WriteLine("[1] Samen pflanzen (1 AP)");
                    Console.WriteLine("[2] Feld wässern (1 AP)");
                    Console.WriteLine("[3] Feld verlassen");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe == 1 || Eingabe == 2 || Eingabe == 3) == false)
                    {

                    }
                    return Eingabe;

                case "Feld_Auswahl":
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Wähle bitte einen Slot aus: [1-9]");
                    feld_anzeigen_simpel();
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe < 10) == false)
                    {

                    }
                    return Eingabe;
                case "Feld_Verlassen":
                    Console.WriteLine("Willst du weiter machen?");
                    Console.WriteLine("[1] Weiter machen.");
                    Console.WriteLine("[2] Feld verlassen.");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe == 1 || Eingabe == 2) == false)
                    {

                    }
                    return Eingabe;
            }
            return 0;

        }
        public int Benutzerauswahl_planzen(int zahl, Spielstand spielstand1)
        {
            switch (zahl)
            {
                case 1:

                    Console.WriteLine("Was willst du planzen?");
                    Console.WriteLine();
                    Console.WriteLine("1: " + spielstand1.Inventarfelder[1] + "Anzahl: " + spielstand1.Anzahl_Inventar[1]);
                    Console.WriteLine("2: " + spielstand1.Inventarfelder[2] + "Anzahl: " + spielstand1.Anzahl_Inventar[2]);
                    Console.WriteLine("3: " + spielstand1.Inventarfelder[3] + "Anzahl: " + spielstand1.Anzahl_Inventar[3]);
                    Console.WriteLine("4: " + spielstand1.Inventarfelder[4] + "Anzahl: " + spielstand1.Anzahl_Inventar[4]);
                    Console.WriteLine("5: Zurück zum Menü)");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    while (Usereingabe_testen(Eingabe == 1 || Eingabe == 2 || Eingabe == 3 || Eingabe == 4 || Eingabe == 5) == false)
                    {
                    }
                    return (Eingabe);

                default:
                    return 0;
            }

        }

        public bool Usereingabe_testen(bool test)
        {
            if (test == false)
            {
                Console.WriteLine(Eingabe);
                Console.WriteLine("Das kannst du leider nicht tun. Bitte Auswahl wiederholen.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                return false;
            }
            return true;
        }

        public void feld_anzeigen_simpel()
        {
            Console.WriteLine("+--------------------+");
            Console.WriteLine("|      |      |      |");
            Console.WriteLine("|   1  |   2  |   3  |");
            Console.WriteLine("|      |      |      |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|      |      |      |");
            Console.WriteLine("|   4  |   5  |   6  |");
            Console.WriteLine("|      |      |      |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|      |      |      |");
            Console.WriteLine("|   7  |   8  |   9  |");
            Console.WriteLine("|      |      |      |");
            Console.WriteLine("+--------------------+");

        }
    }

}
