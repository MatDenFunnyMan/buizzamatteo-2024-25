// ES 1

const int NUM_MAX = 20;

string[] interrogati = new string[10];
int pos = 0;

void menu()
{
    Console.WriteLine(" --- INTERROGAZIONI VOLONTARIE CLASSE 4Ai --- ");
    Console.WriteLine("OPZIONI:");
    Console.WriteLine("1. Inserisci interrogato");
    Console.WriteLine("2. Cancella interrogato");
    Console.WriteLine("3. Stampa interrogati");
    Console.WriteLine("4. Ordina lista interrogati");
    Console.WriteLine("5. Estrai interrogati");
    Console.WriteLine("0. Esci");
}

string nome_studente()
{
    string studente = "";
    bool giusto = false;
    do
    {
        Console.Write("Inserisci nome studente: ");
        studente = Console.ReadLine();

        if (string.IsNullOrEmpty(studente) == false && studente.Length > 3)
        {
            giusto = true;
        }
        else
        {
            Console.WriteLine("Errore!");
        }

    } while (giusto == false);

    return studente;
}

int indice()
{
    int indice = 0;
    bool giusto = false;
    do
    {
        Console.Write("Inserisci l'indice: ");
        indice = int.Parse(Console.ReadLine());

        if (indice > 0 && indice <= interrogati.Count())
        {
            giusto = true;
        }
        else
        {
            Console.WriteLine("Errore! Indice non valido!");
        }
    } while (giusto == false);

    return indice;
}

void aggiungi(string nuovo_interrogato, string[] array, ref int pos)
{
    if (pos < NUM_MAX)
    {
        array[pos] = nuovo_interrogato;
        pos++;
    }
}

void elimina(string[] array, ref int pos)
{
    if (pos == 0)
    {
        Console.WriteLine("Nessun interrogato da eliminare!");
        return;
    }

    stampa(array);
    int ind = indice(); // Usa la funzione già creata per ottenere l'indice.

    if (ind >= 0 && ind < pos)
    {
        // Sposta gli elementi a sinistra per "eliminare" quello indicato.
        for (int i = ind; i < pos - 1; i++)
        {
            array[i] = array[i + 1];
        }

        pos--;

        Console.WriteLine("Interrogato eliminato con successo!");
    }
    else
    {
        Console.WriteLine("Indice non valido!");
    }
}

void stampa(string[] array)
{
    for (int i = 0; i < pos; i++)
    {
        Console.WriteLine($"{i} - {interrogati[i]}");
    }
}

void BubbleSort(string[] studenti, int posizione)
{
    bool scambiato;

    // Bubble Sort
    for (int i = 0; i < posizione - 1; i++)
    {
        scambiato = false;

        for (int j = 0; j < posizione - 1 - i; j++)
        {
            if (!string.IsNullOrEmpty(studenti[j + 1]) && string.Compare(studenti[j], studenti[j + 1]) > 0)
            {
                string temp = studenti[j];
                studenti[j] = studenti[j + 1];
                studenti[j + 1] = temp;
                scambiato = true;
            }
        }

        if (!scambiato)
            break;
    }
}

int scelta = -1;
do
{
    menu();
    Console.Write("Scelta: ");
    try
    {
        scelta = int.Parse(Console.ReadLine());
        switch (scelta)
        {
            case 1:
                aggiungi(nome_studente(), interrogati, ref pos);
                break;

            case 2:
                elimina(interrogati, ref pos);
                break;

            case 3:
                stampa(interrogati);
                break;

            case 4:
                BubbleSort(interrogati, pos);
                Console.WriteLine("Lista ordinata:");
                stampa(interrogati);
                break;

            case 5:
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Inserisci un numero!");
    }

} while (scelta != 0);
