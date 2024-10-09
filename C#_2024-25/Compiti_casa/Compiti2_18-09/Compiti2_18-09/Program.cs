/* ES 6
 * Scrivere un programma C# che chiede di inserire 3 numeri interi. 
 * Occorre calcolare e visualizzare la media aritmetica di questi 3 numeri (media = somma dei numeri / 3)
 */

float n1, n2, n3, media;

Console.Write("Inserire numero 1: ");
n1 = float.Parse(Console.ReadLine());
Console.Write("Inserire numero 2: ");
n2 = float.Parse(Console.ReadLine());
Console.Write("Inserire numero 3: ");
n3 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3) / 3;
Console.WriteLine($"La media tra i 3 numeri è {media}\n");

/* ES 7
 * Scrivere un programma C# che chiede di inserire i voti presi da due candidati alle elezioni. 
 * Occorre poi visualizzare il totale dei voti e il numero di voti presi da ciascun candidato espresso in % rispetto al totale
 */

int voti1, voti2, totvoti;
float perc1, perc2;

Console.Write("Inserire numero voti candidato 1: ");
voti1 = int.Parse(Console.ReadLine());
Console.Write("Inserire numero voti candidato 1: ");
voti2 = int.Parse(Console.ReadLine());

totvoti = voti1 + voti2;

perc1 = ((float)voti1 / (float)totvoti) * 100;
perc2 = ((float)voti2 / (float)totvoti) * 100;

Console.WriteLine($"Totale dei voti: {totvoti}");
Console.WriteLine($"Percentuale voti candidato 1: {perc1}");
Console.WriteLine($"Percentuale voti candidato 2: {perc2}\n");

/* ES 8
 * Scrivere un programma C# che chiede di inserire il lato di un pentagono e stampa la misura del suo perimetro
 */

float lato, perimetro;

Console.Write("Inserire misura lato pentagono: ");
lato = float.Parse(Console.ReadLine());

perimetro = lato * 5;

Console.WriteLine($"Il perimetro del pentagono è {perimetro}\n");

/* ES 9
 * Per preparare 100 grammi di pesto alla genovese servono 27 grammi di basilico fresco e 11,5 grammi di pinoli.
 * Scrivere un programma C# che chiede in ingresso il numero di grammi di pesto che si vuol preparare. 
 * Stampa il peso (in grammi) di basilico e di pinoli che serve per realizzare la quantità di pesto fornita in input dall'utente
 */

float gPesto, basilico100, pinoli100, gBasilico, gPinoli;

Console.Write("Inserisci i grammi di pesto da preparare: \n");
gPesto = float.Parse(Console.ReadLine());

basilico100 = (float)27.0;
pinoli100 = (float)11.5;
gBasilico = (basilico100 / 100) * gPesto;
gPinoli = (pinoli100 / 100) * gPesto;

Console.WriteLine($"Per {gPesto} grammi di pesto servono:");
Console.WriteLine($"{gBasilico} grammi di basilico.");
Console.WriteLine($"{gPinoli} grammi di pinoli.");