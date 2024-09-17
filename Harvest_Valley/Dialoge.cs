using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Dialoge
    {

        public void Begrueßung()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine(@"                   ┌───────────────┐");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"               ┌────────────────────────┐");
            Console.WriteLine(@"               └════════════════════════┘");
            Console.WriteLine(@"                  / ~~~~~     ~~~~~ \");
            Console.WriteLine(@"                 /|  \0/|     |\0/  |\");
            Console.WriteLine(@"                 W   ---  / \  ---   W");
            Console.WriteLine(@"                 \.      |. .|      ./");
            Console.WriteLine(@"                  |                 |");
            Console.WriteLine(@"                  \    #########    /");
            Console.WriteLine(@"                   \  ##└─────┘##  /");
            Console.WriteLine(@"                    \##         ##/");
            Console.WriteLine(@"                     \_____v_____/");

            Console.WriteLine();
            Console.WriteLine("\"Willkommen in Harvest Valley!\"");
            Thread.Sleep(1000);
            Console.WriteLine("\"Ich bin Bürgermeister Henry und ab heute gehört dir offiziell die alte Farm westlich des Dorfs.\"");
            Thread.Sleep(2500);
            Console.WriteLine();
            Console.WriteLine("Bürgermeister Henry lächelt dich offenherzig an.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("\"Bevor ich dich in Ruhe einziehen lasse...Ich befüchte mir ist dein Name entfallen.\"");
            Thread.Sleep(2500);
            Console.WriteLine();
            Console.Write("Drücke Weiter......[Enter]");
            Console.ReadKey();
           
            Console.Clear();
            

        }

        public void Begrueßung2(string charaktername, string farmname)
        {
            Console.Clear();

            Console.WriteLine(@"                   ┌───────────────┐");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"                   │ │ │           │");
            Console.WriteLine(@"               ┌────────────────────────┐");
            Console.WriteLine(@"               └════════════════════════┘");
            Console.WriteLine(@"                  / ~~~~~     ~~~~~ \");
            Console.WriteLine(@"                 /|  \0/|     |\0/  |\");
            Console.WriteLine(@"                 W   ---  / \  ---   W");
            Console.WriteLine(@"                 \.      |. .|      ./");
            Console.WriteLine(@"                  |                 |");
            Console.WriteLine(@"                  \    #########    /");
            Console.WriteLine(@"                   \  ##└─────┘##  /");
            Console.WriteLine(@"                    \##         ##/");
            Console.WriteLine(@"                     \_____v_____/");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"\"Ah natürlich! {charaktername}.\"");
            Thread.Sleep(1000);
            Console.WriteLine("\"Die Dorfewohner baten mich dir folgendes Einzugsgeschenk zu überbringen...\"");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Du erhältst:");
            Console.WriteLine("2x Kartoffelsamen");
            Console.WriteLine("2x Tomatensamen");
            Console.WriteLine("2x Rübensamen");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine($"\"Jetzt lasse ich dich aber erst einmal in Ruhe deine {farmname} Farm erkunden.\"");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.Write("Drücke Weiter......[Enter]");
            Console.ReadKey();
            Console.ResetColor();

        }

        public void Ending()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("═════════════════════════════E N D E══════════════════════════════");
            Console.WriteLine();
            Console.WriteLine("Du hast den aktuell letzen Tag erreicht!");
            Console.WriteLine("Vielen Dank, dass du Harvest Valley gespielt hast.");
            Console.WriteLine();
            Console.WriteLine("Bitte erwirb das DLC [Harvest Valley - Unlimited] um neue Tage freizuschalten!");
            Console.WriteLine();
            Console.Write("Drücke Weiter......[Enter]");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     ══════════════════════════C R E D I T S═══════════════════════════");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     Angelina: \"Ich hab keine Ahnung was ich hier tue oder warum?!\"");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("             Leah: \"Im Zweifelsfall: Bring den User um!\"");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine(" Sascha: \"Kannst ja noch direkt ein Verwaltungstool für den Shop dazuschreiben!\"");
            Thread.Sleep(3000);
            

            Environment.Exit(0);
        }

    }
}
