/* ES 1
 * Scrivere un programma C# che chiede di inserire il numero di biglietti che si vuole acquistare. 
 * Sapendo che ogni biglietto costa 5 euro, visualizzare il costo totale dell'acquisto
 */

int ticket;

Console.Write("Inserire numero biglietti: ");
ticket = int.Parse(Console.ReadLine());

Console.WriteLine($"Il costo totale dell'acquisto è di €{ticket * 5}\n");

/* ES 2
 * Scrivere un programma C# che chiede di inserire base e altezza di un rettangolo e visualizza area e perimetro
 */

float basee, alteza, area, perimetro;

Console.Write("Inserire misura base rettangolo: ");
basee = float.Parse(Console.ReadLine());
Console.Write("Inserire misura altezza rettangolo: ");
alteza = float.Parse(Console.ReadLine());

area = basee * alteza;
perimetro = (alteza + basee) * 2;

Console.WriteLine($"L'area del rettangolo è {area}");
Console.WriteLine($"Il perimetro del rettangolo è {perimetro}\n");

/* ES 3
 * Scrivere un pogramma C# che chiede di inserire il raggio di una cerchio e visaulizza circonferenza e area del cerchio
 */

float raggio, circ, area_c, pi;

Console.Write("Inserire misura raggio: ");
raggio = float.Parse(Console.ReadLine());

pi = 3.14f;
circ = (pi * 2) * raggio;
area_c = (float)pi * (float)Math.Pow(raggio, 2);

Console.WriteLine($"La circonferenza del cerchio è {circ}");
Console.WriteLine($"L'area del cerchio è {area_c}\n");

/* ES 4
 * Scrivere un pogramma C# che chiede di inserire il lato di un cubo e visualizza il valore del volume
 */

float lato_cubo, volume;

Console.Write("Inserire misura lato del cubo: ");
lato_cubo = float.Parse(Console.ReadLine());

volume = (float)Math.Pow(lato_cubo, 3);
Console.WriteLine($"Il volume del cubo è {volume}\n");

/* ES 5
 * Sia data la formula y=2x+3, chiedere all'utente di inserire il valore di x e visualizzare il valore corrispondente di y. 
 * Esempio: x=4 --> y=11
 */

int x, y;

Console.Write("Inserire valore di x: ");
x = int.Parse(Console.ReadLine());

y = (2 * x) + 3;
Console.WriteLine($"Il valore dell'equazione è di {y}\n");