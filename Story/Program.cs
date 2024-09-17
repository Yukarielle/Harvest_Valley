//Startmenü?
Console.WriteLine("HARVEST VALLEY - Das Erntefest");
Console.WriteLine("[1]Spiel starten");
Console.WriteLine("[2]Beenden");

//ifelse in while = Mit Eingabe 1 und 2. 1 Startet Einführungsdialog (verlässt while), 2 Beendet Console mit:
//Console.WriteLine("Du hast das Spiel beendet."); (verlässt while)
//Und fängt Fehler ab mit:
//Console.WriteLine("Ungültige Eingabe. Bitte versuch es erneut."); (startet while erneut)
Console.ReadLine(); //<- Usereingabe mit abfangen von Fehleingaben.
Console.Clear();

//Einführungsdialog:

Console.WriteLine("\"Willkommen in Harvest Valley!\"");
Thread.Sleep(1000); //<---Angepasste Pausen zwischen den Dialogen, damit es sich wie
                    //ein RPG anfühlt. Je nach Textlänge.
Console.WriteLine("\"Ich bin Bürgermeister Henry und ab heute gehört dir offiziell die alte Farm westlich des Dorfs.\"");
Thread.Sleep(1000);
Console.WriteLine("Bürgermeister Henry lächelt dich offenherzig an.");
Thread.Sleep(1000);
Console.WriteLine("\"Bevor ich dich in Ruhe einziehen lasse...Ich befüchte mir ist dein Name entfallen.\"");

//Namenserstellung:
Console.WriteLine("Wie soll dein Charakter heißen?"); //<-Wähle weise! XD
Console.ReadLine(); //<--string für Charaktername
Console.WriteLine("Wie soll deine Farm heißen?");
Console.WriteLine("________________ Farm");
Console.ReadLine(); //<--string für Farmname


//Dialog nach Namenserstellung
// + Erstellung vorhandener Samen im Spiel!!!! 
Console.WriteLine("\"Ah natürlich! <stringname>. Aber jetzt richte dich erst einmal in deiner <stringfarmname> Farm ein.");
Console.WriteLine("Hier habe ich ein kleines Willkommensgeschenk für dich\"");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Du erhältst <anzahl><string> Samen und <anzahl><string> Samen.");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("\"Pflanze sie doch in dein neues Feld. Das Erntefest findet in ein paar Tagen statt.");
Console.WriteLine("Das Dorf würde sich über deine Beteiligung sehr freuen\"");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Bürgermeister Henry verabschiedet sich von dir und lässt dir etwas Zeit in deinem neuen Zuhause anzukommen.");


//Option User
//Jeder Tag stellt die Frage
//Endlosschleife zwischen Feld und Marktplatz (wie??) (Wenn Shop/Feld verlassen wird!)
//Eventuell Auswahl beim bepflanzen oder einkaufen nochmal mit in Schleife packen
Console.WriteLine("Tag 1");
Console.WriteLine("Was möchtest du als nächstes tun?");
Console.WriteLine("[1]Feld (um Pflanzen kümmern)");
Console.WriteLine("[2]Marktplatz (Ein- und Verkaufen)");
Console.WriteLine("[3]Schlafen (Nächsten Tag anbrechen)");


//Wenn man zum Feld geht.
Console.WriteLine("Du hast dein Feld erreicht.");
Console.WriteLine("Folgende Pflanzen sind reif und wurden geerntet: \n<anzahl><Pflanze>, <anzahl><Pflanze>, <anzahl><Pflanze>, <anzahl><Pflanze>");
Console.WriteLine("Aktuell besitzt du <anzahl> <samen>, <anzahl> <samen>, <anzahl> <samen> und <anzahl> <samen>");
Console.WriteLine("Welche möchtest du einpflanzen?");
//Schleife Feld bepflanzen.
Console.WriteLine("[1]Samen");  //Kartoffeln
Console.WriteLine("[2]Samen");  //Tomaten
Console.WriteLine("[3]Samen");  //Kürbise
Console.WriteLine("[4]Samen");  //Gurken
Console.ReadLine();

Console.WriteLine("Wie viele möchtest du einplfanzen.");
Console.ReadLine(); //<-Abfangen wenn Anzahl nicht vorhanden. Anzahl muss irgendwo zwischengespeichert werden.

//ODER Abfrage welches Feld er bepflanzen will und DANN welchen Samen???
//Warscheinlich besser wenn Feld optisch angezeigt wird.
//Pflanzen immer direkt nach einem Tag fertig oder gehen auch unterschiedliche Zeiten? Wie kompliziert?


Console.WriteLine("Möchtest du noch mehr Samen planzen? [J]a / [N]ein");
Console.ReadLine(); //<--Bei ja Schleife Feld starten, bei nein Schleifen Abfrage Laufen starten.
