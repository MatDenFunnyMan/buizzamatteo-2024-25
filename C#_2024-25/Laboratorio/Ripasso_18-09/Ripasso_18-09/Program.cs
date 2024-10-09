// Primo programma di ripasso
// Input e Output di base con console

string nome;

Console.WriteLine("*** Programma di ripasso ***");
Console.WriteLine("Messaggio di prova letsgosky");
Console.Write("Come ti chiami? ");

nome = Console.ReadLine(); // Assegnamento

Console.Write("Buongiorno, ");
Console.WriteLine(nome);

// Oppure

Console.WriteLine("Ciao, " + nome);

int x;
Console.Write("Dammi un numero: ");

x = int.Parse(Console.ReadLine());
Console.WriteLine($"Hai inserito il numero {x}, che moltiplicato per 5 fa {x*5}"); // Stringa interpolata con C# --> usa il $
