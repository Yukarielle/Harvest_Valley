using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Events
    {
        public void CheckEvent(Spielstand Spielstand)
        {
            switch (Spielstand.Tag)
            {
                case 1:
                    Console.WriteLine("Heute ist wie immer ein sonniger Tag.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 2:
                    Console.WriteLine("Würde es regnen müsstest du heute nicht gießen... Tja, tut es aber nicht!");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 3:
                    Console.WriteLine("Hast du dich gefragt ob es jemals regnen wird?.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 4:
                    Console.WriteLine("Heute ist wie immer, wer hätte das gedacht, ein sonniger Tag.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 5:
                    Console.WriteLine("═════════════════E R N T E F E S T══════════════════");
                    Console.WriteLine("Bitte erwirb das DLC [Erntefest 2.0] um die Inhalte des Erntefestes zu genießen!");
                    break;
                case 6:
                    Console.WriteLine("Heute ist wie immer, wer hätte das gedacht, ein sonniger Tag.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 7:
                    Console.WriteLine("Heute ist wie immer, wer hätte das gedacht, ein sonniger Tag.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 8:
                    Console.WriteLine("Heute ist wie immer, wer hätte das gedacht, ein sonniger Tag.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 9:
                    Console.WriteLine("Heute ist wie immer, wer hätte das gedacht, ein sonniger Tag.");
                    Console.WriteLine("Bitte denke daran, dass deine Pflanzen nur wachsen wenn sie am Tag zuvor gegossen wurden!");
                    break;
                case 10:
                    Console.WriteLine("═════════════════E N D E══════════════════");
                    Console.WriteLine("Du hast den aktuell letzen Tag erreicht!");
                    Console.WriteLine("Vielen Dank, dass du Harvest Valley gespielt hast.");
                    Console.WriteLine("Bitte erwirb das DLC [Harvest Valley - Unlimited] um neue Tage freizuschalten!");

                    break;

                default: break;
            }
        }
    }
}
