
/* ES 1
 * Stringhe
 * Scrivere un programma C# che si comporta nella seguente maniera: per prima cosa sceglie in maniera random una parola tra 5 disponibili (sceglietele voi, parole non troppo corte). Stabilita la parola, chiede all'utente di indovinare tale parola. Ma prima, l'utente può inserire 3 lettere (vocali o consonanti). Inserite le 3 lettere, verrà mostrata la parola "a lettere scoperte" e verrà chiesto all'utente di indovinare. Se l'utente non indovina, mostrare la soluzione.
 * Esempio di esecuzione:
               - il computer sceglie la parola "aquilone" (senza mostrarla all'utente)
               - l'utente inserisce le lettere a, l, n
               - viene mostrata a schermo la stringa   a***l*n*
               - a questo punto l'utente dovrà provare a indovinare la parola, con le lettere che vede
*/

List<string> animali = new List<string>() { "cane", "gatto", "lupo", "serpente", "coniglio", "ghepardo"};
List<char> caratteri = new List<char>();

Random random = new Random();
int indice = random.Next(animali.Count);
string parola = animali[indice];

int i = 0;
char carattere_scelto = '\0'; // Carattere nullo in C#

do
{
    Console.Write($"Inserisci carattere alfabetico ({i + 1}/3): ");
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input) == false && input.Length == 1)
    {
        carattere_scelto = input[0];
        if (char.IsLetter(carattere_scelto) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Errore! Input invalido!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            caratteri.Add(carattere_scelto);
            i++;
        }
        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Errore! Carattere non valido!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    

} while (i < 3);

string parola_finale = "";

foreach (char c in parola)
{
    if (caratteri.Contains(c))
    {
        parola_finale += c;
    }
    else
    {
        parola_finale += "*";
    }
}

Console.WriteLine(parola_finale);

bool giusto = false;
do
{
    Console.Write("Indovina la parola: ");
    string risposta = Console.ReadLine().ToLower();

    if (risposta == parola)
    {
        giusto = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Complimenti! La parola era {parola}!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Peccato! Non è la parola giusta. Ritenta!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

} while (giusto == false);

