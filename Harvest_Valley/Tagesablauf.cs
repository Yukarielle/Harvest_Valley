using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Tagesablauf : Inventar
    {
        public int Menuewahl1, Menuewahl2, Menuewahl3, Menuewahl4;
        public bool auswahl, weiterEinkaufen, weiterfelden;

        public void Tag(Spielstand spielstand1, Aktionen menues, Shop mechanik, Felder feld, Events events)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            
            spielstand1.Aktionspunkte = spielstand1.Max_aktionspunkte;
            
            Console.WriteLine($"{spielstand1.Tag}.Tag");
            Console.WriteLine();
            Console.WriteLine("════ Verkauf ═══");
            feld.gewachsen(spielstand1);
            Console.WriteLine($"Du hast aktuell {spielstand1.Gold} Gold.");
            Console.WriteLine();
            Console.WriteLine("════ Neuigkeiten ═══");
            events.CheckEvent(spielstand1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            auswahl = true;
            while(auswahl == true)
            {
                
                
                Menuewahl1 = menues.Spielmenues("Weg");
                if (Menuewahl1 == 1)
                {
                    Console.WriteLine($"Du hast noch {spielstand1.Aktionspunkte} Aktionspunkte.");
                    if (spielstand1.Aktionspunkte <= 0)
                    {
                        Console.WriteLine("Du hast keine Aktionspunkte mehr");
                        Console.WriteLine("und kannst dein Feld heute nicht mehr weiter bestellen.");
                    }
                    weiterfelden = true;
                    while (weiterfelden == true && spielstand1.Aktionspunkte > 0)
                    {
                        Console.ResetColor();
                        Console.Clear();
                        
                        
                        feld.Feld_Anzeigen();
                        Console.WriteLine("Du hast noch " + spielstand1.Aktionspunkte + " Aktionspunkte.");
                        Menuewahl2 = menues.Spielmenues("Feld");

                        if (Menuewahl2 == 1)
                        {
                            Menuewahl3 = menues.Spielmenues("Feld_Auswahl");
                            Menuewahl4 = menues.Benutzerauswahl_planzen(1, spielstand1);
                            switch (Menuewahl4)
                            {
                                case 1:
                                    feld.feldbestücken(Menuewahl3, "K", Menuewahl4, spielstand1);
                                    
                                    break;
                                case 2:
                                    feld.feldbestücken(Menuewahl3, "E",Menuewahl4, spielstand1);
                                    
                                    break;
                                case 3:
                                    feld.feldbestücken(Menuewahl3, "T", Menuewahl4, spielstand1);
                                    
                                    break;
                                case 4:
                                    feld.feldbestücken(Menuewahl3, "R", Menuewahl4, spielstand1);
                                    
                                    break;
                                case 5:
                                    break;

                            }
                        }
                        if (Menuewahl2 == 2)
                        {

                            Menuewahl3 = menues.Spielmenues("Feld_Auswahl");
                            feld.feldwaessern(Menuewahl3);
                            spielstand1.Aktionspunkte--;
                        }
                        if (Menuewahl2 ==1 && spielstand1.Aktionspunkte > 0 || Menuewahl2 ==2 && spielstand1.Aktionspunkte > 0)
                        {
                            Menuewahl3 = menues.Spielmenues("Feld_Verlassen");
                            if (Menuewahl3 == 1)
                            {
                                weiterfelden = true;
                            }
                            if (Menuewahl3 == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                weiterfelden = false;
                            }
                        }
                        else
                        {
                            weiterfelden = false;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                    }
                  


                }
                if (Menuewahl1 == 2)
                {
                    mechanik.Inventar_Shop();
                    weiterEinkaufen = true;
                    do
                    {
                       weiterEinkaufen = mechanik.Einkaufen(spielstand1);
                    }
                    while (weiterEinkaufen == true);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
            
                }
                if (Menuewahl1 == 3)
                {
                    
                    Check_Inventar(spielstand1);
                }
                if(Menuewahl1 == 4)
                {
                    spielstand1.Tag++;
                    Console.WriteLine("Du legst dich schlafen.");
                    auswahl = false;
                }
            }
        }
    }
}
