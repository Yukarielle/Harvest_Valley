using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Valley
{
    internal class Spielstand
    {
        private int tag;
        private int gold;
        private string[] inventarfelder;
        private int[] anzahl_Inventar;
        private int aktionspunkte;
        private int max_aktionspunkte;

        public int Tag { get => tag; set => tag = value; }
        public int Gold { get => gold; set => gold = value; }
        public string[] Inventarfelder { get => inventarfelder; set => inventarfelder = value; }
        public int[] Anzahl_Inventar { get => anzahl_Inventar; set => anzahl_Inventar = value; }
        public int Aktionspunkte { get => aktionspunkte; set => aktionspunkte = value; }
        public int Max_aktionspunkte { get => max_aktionspunkte; set => max_aktionspunkte = value; }

        public Spielstand()
        {
            Tag = 1;
            Gold = 150;
            Inventarfelder = new string[5];
            Anzahl_Inventar = new int[20];
            Inventarfelder[1] = "Kartoffelsamen";
            Inventarfelder[2] = "Erdbeersamen";
            Inventarfelder[3] = "Tomatensamen";
            Inventarfelder[4] = "Rübensamen";
            Anzahl_Inventar[1] = 2;
            Anzahl_Inventar[2] = 0;
            Anzahl_Inventar[3] = 2;
            Anzahl_Inventar[4] = 2;
            Max_aktionspunkte = 10;
            Aktionspunkte = 0;

        }
    }
}
