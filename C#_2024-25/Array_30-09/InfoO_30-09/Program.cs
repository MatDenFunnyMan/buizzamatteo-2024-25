/* C# - Array (27/09)

Lista = parte vuota e può essere riempita QUASI all’infinito, fino a quando la memoria è piena.

Ai tempi, le liste non erano utilizzate perché le memorie ai tempi erano limitate. Perciò venivano utilizzati gli array.

L’array è come se fosse una lista di elementi limitata, già prefissata. I vettori sono i padri delle liste, perché anche loro utilizzano le parentesi quadre [ ]
In questo caso, il count negli array non è tanto utile perché sappiamo già quanto grande sarà questa collezione di elementi.

Un vantaggio degli array è che, nonostante la limitata grandezza, sono più veloci in memoria rispetto alla lista.

Es: Da pos. 50 devo prendere un elemento in una posizione dopo  posizione inizio array + (4 x posizione dell’elemento da prendere)

(30/09)

Come si dichiara un array:
int[ ] numeri = new int[10]; --> Questo fa capire al compilatore che vogliamo più di una variabile

Mentre nelle liste abbiamo 4 operazioni: Aggiungi, rimuovi, modifica, stampa
Array ne ha solo 2: Modifica, stampa

AGGIUNGI
a = [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ] --> Devo prendere il primo 0 e sostituirlo

Per fare ciò usiamo una variabile pos --> pos = 0

if pos < a.Count( )
{
    a[pos] = n_elemento
    pos++
}

*/

/*
int[] numeri = new int[10];
for (int i = 0; i < numeri.Length; i++)
{
    Console.WriteLine(numeri[i]);
}
*/

// Aggiungi (array)
const int NUM_MAX = 10;

int[] numeri = new int[10];
int pos = 0;

void aggiungi(int nuovo, int[] a, ref int p)
{
    if (p<NUM_MAX) // Per convenzione si lascia NUM_MAX perchè globale
    {
        a[p] = nuovo;
        p++;
    }
}

void elimina(int posizione, int[] a, ref int pos)
{
    if (posizione < 0 || posizione >= pos)
    {
        return;
    }
    
    for (int i = posizione; i < pos-1; i++)
    {
        a[i] = a[i + 1];
    }
    pos--;
}

aggiungi(3, numeri, ref pos);
aggiungi(10, numeri, ref pos);
aggiungi(20, numeri, ref pos);
aggiungi(30, numeri, ref pos);
aggiungi(40, numeri, ref pos);
aggiungi(50, numeri, ref pos);
aggiungi(60, numeri, ref pos);
aggiungi(70, numeri, ref pos);
aggiungi(80, numeri, ref pos);
aggiungi(90, numeri, ref pos);
elimina(4, numeri, ref pos);

void stampa(int[] a)
{
    // for (int i = 0; i < numeri.Length; i++) --> In questo modo stampa gli spazi vuoti (cioè gli 0)
    for (int i = 0; i < pos; i++)
    {
        Console.WriteLine(numeri[i]);
    }
}

stampa(numeri);

