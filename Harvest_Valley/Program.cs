

using Harvest_Valley;

//Objekte aufrufen:
Startmenue start = new Startmenue();
Namen_Auswahl Auswahl1 = new Namen_Auswahl();
Dialoge dialogEinfuegen = new Dialoge();
Spielstand spielstand1 = new Spielstand();
Tagesablauf ablauf = new Tagesablauf();
Aktionen komplett = new Aktionen();
Shop mechanik = new Shop();
Felder feld1 = new Felder();
Events events = new Events();

//Methoden von oben nach unten aufrufen:
start.MenueAuswahl(dialogEinfuegen);
Auswahl1.NamenSetzen(dialogEinfuegen);

while (spielstand1.Tag <= 9) //<-- Spiel geht aktuell max. 10 Tage
{
    ablauf.Tag(spielstand1, komplett, mechanik, feld1, events);

}

dialogEinfuegen.Ending();


