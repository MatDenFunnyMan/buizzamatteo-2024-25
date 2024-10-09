/* ES 2
 * Scrivere un programma C#, organizzato in funzioni, per gestire le interrogazioni orali su base volontaria. Il programma deve presentare il seguente menù:
   - aggiungi studente: consente di aggiungere il nominativo di un singolo studente all'elenco di studenti disponibili. Questa voce di menù viene usata per aggiungere tutti gli studenti della classe; si assume che all'interno di una classe non possano esistere due studenti con lo stesso nominativo; il nominativo non può essere vuoto nè avere più di 30 caratteri. Deve inoltre essere costituito solo da lettere (no cifre, no caratteri speciali);
  - cancella studente: consente di cancellare il nominativo di un singolo studente, indicando il numero progressivo relativo allo studente che si vuole eliminare;
 - stampa studenti: stampa tutto l'lenco di studenti
 - ordina elenco: ordina l'elenco in ordine alfabetico, dalla A alla Z
  - estrai studenti: richiede di inserire il numero di studenti da "pescare" come volontari. Il numero deve ovviamente essere inferiore al numero totale di studenti della classe. Una volta stabilito il numero di estrazioni da fare, vanno estratti (ed elencati) gli studenti scelti. Lo stesso studente non può essere estratto più volte!
- esci: termina il programma

*/

List<string> interrogati = new List<string>();

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

void inserisci()
{
    bool giusto = false;
    do
    {
        Console.Write("Inserisci nome studente: ");
        string studente = Console.ReadLine();

        if (string.IsNullOrEmpty(studente) == false && studente.Length > 3)
        {
            interrogati.Add(studente);
            giusto = true;
        }
        
        else
        {
            Console.WriteLine("Errore!");
        }
    
    } while (giusto == false);
}

void stampa()
{
    int i = 0;
    foreach (string s in interrogati)
    {
        Console.WriteLine($"{i} - {s}");
        i++;
    }
}

void elimina()
{
    stampa();

    bool giusto = false;
    do
    {
        Console.Write("Inserisci indice studente: ");
        int pos = int.Parse(Console.ReadLine());

        if (pos < 0 || pos > interrogati.Count()-1)
        {
            Console.WriteLine("Errore! Indice invalido!");
        }
        else
        {
            giusto = true;
            interrogati.RemoveAt(pos);
        } 
    
    } while (giusto == false);
}

void ordina()
{
    if (interrogati.Count() < 0)
    {
        Console.WriteLine("Errore! Lista interrogati vuota!");
    }
    else
    {
        interrogati.Sort();
        stampa();
    }
}
 
void estrazione()
{
    int numEstrazioni;
    Console.Write($"Inserisci numero di interrogati da estrarre (massimo {interrogati.Count}): ");
    if (int.TryParse(Console.ReadLine(), out numEstrazioni) && numEstrazioni < 0 && numEstrazioni >= interrogati.Count)
    {
        Console.WriteLine("Input non valido!");
    }
    else
    {
        Random random = new Random();
        List<string> studEstratti = new List<string>();

        while (studEstratti.Count < numEstrazioni)
        {
            int iCasuale = random.Next(interrogati.Count);
            string sCasuale = interrogati[iCasuale];

            if (!studEstratti.Contains(sCasuale))
            {
                studEstratti.Add(sCasuale);
                Console.WriteLine($"Gli studenti estratti sono: {sCasuale}");
            }
        }
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
                inserisci(); break;

            case 2:
                elimina(); break;   

            case 3:
                stampa(); break;

            case 4:
                ordina(); break;

            case 5:
                estrazione(); break;
        }
    }
    
    catch (FormatException)
    {
        Console.WriteLine("Inserisci un numero!");
    }

} while (scelta != 0);




