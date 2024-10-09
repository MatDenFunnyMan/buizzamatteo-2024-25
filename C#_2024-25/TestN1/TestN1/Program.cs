// See https://aka.ms/new-console-template for more information

/*
int a, b;
a = 10;
b = 5;
Console.WriteLine(a-b);
*/

/*
Console.WriteLine("inserisci il primo numero intero:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il secondo numero intero:");
int num2 = int.Parse(Console.ReadLine());
float media = (num1 + num2) / 2; // Trasforma la variabile in un intero con un cast implicito (SBALGIATO)
Console.WriteLine(media);
*/

/*
Console.WriteLine("inserisci il primo numero intero:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il secondo numero intero:");
int num2 = int.Parse(Console.ReadLine());
float media = ((float)num1 + (float)num2) / 2; // Se l'opacità del testo è ridotta, quindi è sbiadito, vuol dire che il programma dice che non servirebbe (ma si può usare)
Console.WriteLine(media);
*/

/*
string a = "ciao";

try
{
    int b = int.Parse(a);   // cast esplicito
    Console.WriteLine(b);   // Se la riga 31 esplode, skippa il codice fino alla riga 35
}

catch(Exception e) { Console.WriteLine("Formato non valido!"); }// La variabile b messa serve per contenere informazioni riguardanti l'eccezioni

// catch(Exception e) { Console.WriteLine(e.ToString()); } --> Per stampare le informazioni e l'errore trovato dall'eccezione

catch(ArgumentException b) { Console.WriteLine("Argomento non valido"); } // Il programma dà errore, perchè la Exception messa prima è più forte (visto che prende tutte le eccezioni)

// la Try, nel momento dell'esecuzione, passa direttamente alla catch, verificando l'eccezione.
// Posso inserire più Catch alla volta
*/

/*
int a = 0;
// null --> chiamato None in Python 
try
{
    a = int.Parse(Console.ReadLine());
}

catch (ArgumentException b) { Console.WriteLine("Argomento non valido"); }
catch (Exception e) { Console.WriteLine("Formato non valido!"); }

Console.WriteLine(a);
*/

/*
//int i;
for (int i = 0; i < 10; i++) ; // in questo caso, i è una variabile locale
{
    // ...
}
Console.WriteLine(i);
*/

/*
int i;
for (i = 0; i < 10; i++) ; // in questo caso, i è una variabile locale
{
    // ...
}
Console.WriteLine(i);

int j;
for (j = 10; j > 0; j--) ; // in questo caso, i è una variabile locale
{
    // ...
}
Console.WriteLine(j);

int c = 10;
// if (c == 10 &&) || !c; \\\\ && = AND, || = OR, !nome_variabile = NOT
// Math.Pow(4, 7); --> Potenza in C Sharp
{
    // ...
}
Console.WriteLine(c);

int d = 10;
if (d == 0)
{

}
else
{

}
else if (d == 1)
{

}
Console.WriteLine(d);
*/

//a++, ++a
//switch
//while
//do while

/*
int e = 10;
Console.WriteLine(e++);
Console.WriteLine(++e); // Stampa 12 perchè esegue prima l'operazione (e++) + (++e), cioè 10 viene incrementato di 2 (+1 due volte) PRIMA della stampa
Console.WriteLine(e);

int a = 1;
switch (a)
{
    case 1:
        Console.WriteLine("ciao");
        break;
    case 2:
        Console.WriteLine("bye bye");
        break;
    default:    // il cosidetto else del case, come se fosse l'except del try o come l'else
        Console.WriteLine("Cattura il restante"); // Per Python --> case _
        break;
}

int i = 5;
while (i == 0);
{
    // ...
}

do
{

}
while (i == 0);
{

}
*/

// Funzioni in C-Sharp

/*
 * 
 * def somma(a,b):
 *      somma = a+b
 *      return somma
 * 
 * print(somma(10,2))
 */

/*
int somma(int a, int b) // Ricorda che se i dati sono messi in intero, nella riga in cui si chiama la definizione le variabili DEVONO essere intere
{
    int s = a + b;
    return s;
}

Console.WriteLine(somma(10, 20));

void sommaa(int c, int d) // void è una funzione che non restituisce nulla
{
    int s = c + d;
}

float sommaaa(float e, float f) // void è una funzione che non restituisce nulla
{
    float s = e + f;
    return s;
}

Console.WriteLine(sommaaa(10, 20));
*/

/*
void scambia(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;

}
int a, b;
a = 10;
b = 20;
scambia(ref a, ref b);
Console.WriteLine(a);
Console.WriteLine(b);
*/

// Caso in cui usare passaggio per riferimento: quando la funzione deve restituire più di un valore