//Utilizzo le mie classi e i metodi del NAMESPACE "Geometria"
using Geometria;

Console.WriteLine("--------- Calcoli Geometrici sul Rettangolo ---------");

int numeroRettangoli = 0;

//----- rettangolo 1 ------

//Caricamento degli imput da parte dell'utente
Console.Write("\nInserisci un valore per la base: ");
int Base = int.Parse(Console.ReadLine());

Console.Write("Inserisci un valore per la l'altezza: ");
int altezza = int.Parse(Console.ReadLine());
numeroRettangoli++;

//Creo il mio oggetto e lo inizializzo
Rettangolo mioRettangolo = new Rettangolo(Base, altezza);

//Stampo il contenuto del mio oggetto
mioRettangolo.StampaRettangolo(numeroRettangoli);
numeroRettangoli++;


//----- rettangolo 2 -----

//Caricamento degli imput da parte dell'utente
Console.Write("\nInserisci un valore per la base: ");
Base= int.Parse(Console.ReadLine());

Console.Write("Inserisci un valore per la l'altezza: ");
altezza = int.Parse(Console.ReadLine());


//Creo il mio oggetto e lo inizializzo
Rettangolo mioRettangolo2 = new Rettangolo(Base, altezza);

//Stampo il contenuto del mio oggetto
mioRettangolo2.StampaRettangolo(numeroRettangoli);
numeroRettangoli++;

//----- rettangolo 3 -----

//Caricamento degli imput da parte dell'utente
Console.Write("\nInserisci un valore per la base: ");
Base = int.Parse(Console.ReadLine());

Console.Write("Inserisci un valore per la l'altezza: ");
altezza = int.Parse(Console.ReadLine());

//Creo il mio oggetto e lo inizializzo
Rettangolo mioRettangolo3 = new Rettangolo(Base, altezza);

//Stampo il contenuto del mio oggetto
mioRettangolo3.StampaRettangolo(numeroRettangoli);
numeroRettangoli++;


