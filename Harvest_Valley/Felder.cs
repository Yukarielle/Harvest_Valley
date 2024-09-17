using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Felder
    {
        public string[] felder { get; set; }
        public bool[] gewässert { get; set; }
        public int[] Tage_gewachsen { get; set; }
        static int Wachsdauer_Katoffeln = 2;
        static int Wachsdauer_Erdbeeren = 3;
        static int Wachsdauer_Tomaten = 1;
        static int Wachsdauer_Rüben = 1;
        static int Verkaufswert_Kartoffeln = 20;
        static int Verkaufswert_Erdbeeren = 40;
        static int Verkaufswert_Tomaten = 50;
        static int Verkaufswert_Rüben = 60;
        private int Verkaufswert;

        public Felder()
        {
            felder = new string[10];
            gewässert = new bool[10];
            Tage_gewachsen = new int[10];
            felder[1] = "X";
            felder[2] = "X";
            felder[3] = "X";
            felder[4] = "X";
            felder[5] = "X";
            felder[6] = "X";
            felder[7] = "X";
            felder[8] = "X";
            felder[9] = "X";

            gewässert[1] = false;
            gewässert[2] = false;
            gewässert[3] = false;
            gewässert[4] = false;
            gewässert[5] = false;
            gewässert[6] = false;
            gewässert[7] = false;
            gewässert[8] = false;
            gewässert[9] = false;

            Tage_gewachsen[1] = 0;
            Tage_gewachsen[2] = 0;
            Tage_gewachsen[3] = 0;
            Tage_gewachsen[4] = 0;
            Tage_gewachsen[5] = 0;
            Tage_gewachsen[6] = 0;
            Tage_gewachsen[7] = 0;
            Tage_gewachsen[8] = 0;
            Tage_gewachsen[9] = 0;

        }

        public void Feld_Anzeigen()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("So sieht dein Feld aus");
            Console.WriteLine("");
            Console.WriteLine("+--------------------+");
            Console.WriteLine("|      |      |      |");
            // Console.WriteLine("|   "+ felder[1]+"  |   " + felder[2] + "  |   " + felder[3] +"  |");
            Console.Write("|   ");
            if (gewässert[1] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[1]);
            Console.ResetColor();
            Console.Write("  |   ");
            if (gewässert[2] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[2]);
            Console.ResetColor();
            Console.Write("  |   ");
            if (gewässert[3] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[3]);
            Console.ResetColor();
            Console.WriteLine("  |");

            Console.WriteLine("|      |      |      |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|      |      |      |");
            //Console.WriteLine("|   " + felder[4] + "  |   " + felder[5] + "  |   " + felder[6] + "  |");
            Console.Write("|   ");
            if (gewässert[4] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[4]);
            Console.ResetColor();
            Console.Write("  |   ");
            if (gewässert[5] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[5]);
            Console.ResetColor();
            Console.Write("  |   ");
            if (gewässert[6] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[6]);
            Console.ResetColor();
            Console.WriteLine("  |");

            Console.WriteLine("|      |      |      |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|      |      |      |");
            // Console.WriteLine("|   " + felder[7] + "  |   " + felder[8] + "  |   " + felder[9] + "  |");
            Console.Write("|   ");
            if (gewässert[7] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[7]);
            Console.ResetColor();
            Console.Write("  |   ");
            if (gewässert[8] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[8]);
            Console.ResetColor();
            Console.Write("  |   ");
            if (gewässert[9] == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(felder[9]);
            Console.ResetColor();
            Console.WriteLine("  |");

            Console.WriteLine("|      |      |      |");
            Console.WriteLine("+--------------------+");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void feldbestücken(int position_feld, string Gemueseart, int gemueseindex, Spielstand spielstand)
        {
            if (spielstand.Anzahl_Inventar[gemueseindex] < 1)
            {
                Console.WriteLine("Du hast nicht genug Samen");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Du hast einen " + spielstand.Inventarfelder[gemueseindex] + " auf Feld " + position_feld + " gepflanzt");
                felder[position_feld] = Gemueseart;
                spielstand.Anzahl_Inventar[gemueseindex]--;
                spielstand.Aktionspunkte--;
            }


        }

        public void feldwaessern(int position_feld)
        {
            gewässert[position_feld] = true;
        }

        //Wenn ewässert, Pflanzen wachen:
        public void gewachsen(Spielstand spielstand)
        {
            Verkaufswert = 0;
            for (int i = 1; i < felder.Length; i++)
            {
                if (gewässert[i] == true && felder[i] != "X")
                {
                    Tage_gewachsen[i]++;
                    gewässert[i] = false;
                }
            }

            //Array checken, was gepflanz wurde und ob FERTIG und direkt verkaufen:

            for (int i = 1; i < Tage_gewachsen.Length; i++)
            {

                if (felder[i] == "K")
                {
                    if (Tage_gewachsen[i] >= Wachsdauer_Katoffeln)
                    {
                        Console.WriteLine("Deine Kartoffel auf Feld " + i + " wurde für " + Verkaufswert_Kartoffeln + " verkauft");
                        spielstand.Gold = spielstand.Gold + Verkaufswert_Kartoffeln;
                        felder[i] = "X";
                        Verkaufswert = Verkaufswert + Verkaufswert_Kartoffeln;
                    }
                }
                if (felder[i] == "E")
                {
                    if (Tage_gewachsen[i] >= Wachsdauer_Erdbeeren)
                    {
                        Console.WriteLine("Deine Erdbeere auf Feld " + i + " wurde für " + Verkaufswert_Erdbeeren + " verkauft");
                        spielstand.Gold = spielstand.Gold + Verkaufswert_Erdbeeren;
                        felder[i] = "X";
                        Verkaufswert = Verkaufswert + Verkaufswert_Erdbeeren;
                    }
                }
                if (felder[i] == "T")
                {
                    if (Tage_gewachsen[i] >= Wachsdauer_Tomaten)
                    {
                        Console.WriteLine("Deine Tomate auf Feld " + i + " wurde für " + Verkaufswert_Tomaten + " verkauft");
                        spielstand.Gold = spielstand.Gold + Verkaufswert_Tomaten;
                        felder[i] = "X";
                        Verkaufswert = Verkaufswert + Verkaufswert_Tomaten;
                    }
                }
                if (felder[i] == "R")
                {
                    if (Tage_gewachsen[i] >= Wachsdauer_Rüben)
                    {
                        Console.WriteLine("Deine Rübe auf Feld " + i + " wurde für " + Verkaufswert_Rüben + " verkauft");
                        spielstand.Gold = spielstand.Gold + Verkaufswert_Rüben;
                        felder[i] = "X";
                        Verkaufswert = Verkaufswert + Verkaufswert_Tomaten;
                    }
                }

            }
            Console.WriteLine("Du hast heute Feldfrüchte im Wert von " + Verkaufswert + " Gold verkauft");
        }

    }
}

