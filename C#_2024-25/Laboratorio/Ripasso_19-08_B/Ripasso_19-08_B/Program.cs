// Secondo programma - Selezione e Cicli (Ripasso costrutti)

int num;
Console.Write("Dammi un numero: ");
num = int.Parse(Console.ReadLine()); // Conversione in Intero

// Selezione
if (num > 50)
{
    Console.WriteLine("Hai inserito un numero maggiore di 50");
}

// Identifica se è pari o dispari

if ((num % 2) == 0 ) // num % 2 --> "num" modulo (%) di "2" uguale 0 --> Modulo = Resto della divisione tra num. interi
{ 
    Console.WriteLine("Numero pari");
}

else
{
    Console.WriteLine("Numero dispari");
}

if (num == 256)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("DIO");
}

// Operatori logici --> AND (&&), OR (||), NOT (!"nome variabile")

if (num < 0 && num >= -10 )
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Numero leggermente negativo");
}

if (num == 7 || num == 13 || num == 22)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Bonus trovato");
}

/* Ciclo contatore (FOR)
 * Inizializzazione (int i = 0)
 * Condizione di terminazione (i < num)
 * Incremento (i++)
 */

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Conteggi");
for (int i = 1; i < num; i++)
{
    Console.Write(i + " ");
}

int z = -3;
while(z<num)
{
    Console.Write(z + " ");
    z = z + 1;
}

Console.ForegroundColor = ConsoleColor.Blue;
// Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"\n\n©2024 - 4Ai Dalmine. \n Grazie per aver usato il programma");