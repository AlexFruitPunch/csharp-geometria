//Utilizzo le mie classi e i metodi del NAMESPACE "Geometria"
using Geometria;

//Caricamento degli imput da parte dell'utente
Console.Write("Inserisci un valore per la base: ");
int Base = int.Parse(Console.ReadLine());

Console.Write("Inserisci un valore per la l'altezza: ");
int altezza = int.Parse(Console.ReadLine());


//Creo il mio oggetto e lo inizializzo
Rettangolo mioRettangolo = new Rettangolo(Base, altezza);

//Stampo il contenuto del mio oggetto
mioRettangolo.StampaRettangolo();


