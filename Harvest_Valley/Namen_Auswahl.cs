using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Namen_Auswahl
    {
        private string charaktername = "NoName";
        private string farmname = "NoName";

        public string Charaktername { get => charaktername; set => charaktername = value; }
        public string Farmname { get => farmname; set => farmname = value; }

        public Namen_Auswahl()
        {

        }

        public void NamenSetzen(Dialoge dialog)
        {
            bool charakterbool = true;
            bool farmbool = true;
            //string charaktername;
            //string farmname;

            do
            {
                Console.WriteLine("═══════════════════════════CHARAKTER-ERSTELLUNG═══════════════════════════════════════");
                Console.WriteLine();
                Console.WriteLine("Wie soll dein Charakter heißen?");
                Charaktername = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Du heißt jetzt {Charaktername}!");
                Console.WriteLine();
                Console.WriteLine("Willst du den Namen so beibehalten? [J]a / [N]ein");
                string bestätigen = Console.ReadLine().ToLower();

                if (bestätigen == "j" || bestätigen == "ja")
                {
                    //Charaktername = charaktername;
                    charakterbool = false;
                }
                else if (bestätigen == "n" || bestätigen == "nein")
                {
                    Console.WriteLine("Also gut, korrigieren wir deinen Namen:");
                    charakterbool = true;
                }
                else
                {
                    Console.WriteLine("Fehler: Bitte wiederhole den Vorgang.");
                }

            } while (charakterbool == true);

            do
            {
                Console.WriteLine("Wie soll deine Farm heißen?");
                Console.WriteLine("______________-Farm");
                Farmname = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Dein Farm heißt jetzt {Farmname}-Farm!");
                Console.WriteLine();
                Console.WriteLine("Willst du den Namen so beibehalten? [J]a / [N]ein");
                string bestätigen = Console.ReadLine().ToLower();

                if (bestätigen == "j" || bestätigen == "ja")
                {
                    
                    farmbool = false;
                }
                else if (bestätigen == "n" || bestätigen == "nein")
                {
                    Console.WriteLine("Also gut, korrigieren wir den Namen deiner Farm:");
                    farmbool = true;
                }
                else
                {
                    Console.WriteLine("Fehler: Bitte wiederhole den Vorgang.");
                }

                
            } while (farmbool == true);



            dialog.Begrueßung2(Charaktername, Farmname);
        }
        

    }
}
