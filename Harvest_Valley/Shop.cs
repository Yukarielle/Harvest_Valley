using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Harvest_Valley
{
    internal class Shop : Aktionen
    {
        public string[] Shop_Inventar { get; set; }
        public int[] Shop_Kosten { get; set; }

        public void Inventar_Shop()
        {
            Shop_Inventar = new string[5];
            Shop_Kosten = new int[5];
            Shop_Inventar[1] = "Kartoffelsamen";
            Shop_Inventar[2] = "Erdbeersamen";
            Shop_Inventar[3] = "Tomatensamen";
            Shop_Inventar[4] = "Rübensamen";
            Shop_Kosten[1] = 40;
            Shop_Kosten[2] = 80;
            Shop_Kosten[3] = 20;
            Shop_Kosten[4] = 10;

        }

        public int UserAuswahl, Goldkosten, Anzahl;
        public bool weiterEinkaufen = true;
        public bool goldcheck;
        public bool Einkaufen(Spielstand spielstand1)
        {
            UserAuswahl = Spielmenues("Shop_Einkaufen");

            if (UserAuswahl == 5)
            {
                return false;
                
            }
            else
            {
                Console.WriteLine($"Du möchtest also {Shop_Inventar[UserAuswahl]} einkaufen");
                Goldkosten = Shop_Kosten[UserAuswahl];
                Console.WriteLine(UserAuswahl);
                Console.WriteLine($"Du möchtest also {Shop_Inventar[3]} einkaufen");
                Anzahl = Spielmenues("Shop_Anzahl");
                Goldkosten = Goldkosten * Anzahl;
                goldcheck = CheckGold(spielstand1, Goldkosten);
                if (goldcheck == true)
                {
                    spielstand1.Gold = spielstand1.Gold - Goldkosten;
                    spielstand1.Anzahl_Inventar[UserAuswahl] = spielstand1.Anzahl_Inventar[UserAuswahl] + Anzahl;
                    Console.WriteLine($"Du hast {Anzahl} {Shop_Inventar[UserAuswahl]} gekauft.");
                    Console.WriteLine($"Und nun insgesamt {spielstand1.Anzahl_Inventar[UserAuswahl]} {spielstand1.Inventarfelder[UserAuswahl]} im Inventar.");
                    Console.WriteLine($"{spielstand1.Gold} Gold sind noch übrig.");


                }
                else
                {
                    Console.WriteLine("Nicht genügeng Gold!");
                    Console.WriteLine($"Es kostet {Goldkosten} Gold");
                    Console.WriteLine($"Du hast aber leider nur {spielstand1.Gold} Gold");
                }

                UserAuswahl = Spielmenues("Shop_Verlassen");
                if (UserAuswahl == 1)
                {
                    
                    return true;
                }
                if (UserAuswahl == 2)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckGold(Spielstand SpielerGold, int Goldkosten)
        {
            if (Goldkosten > SpielerGold.Gold)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}