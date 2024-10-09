// Esercizi con selezione e cicli
const int lunghezza = 3;
string nome;
int num, vite, numesatto;

Random random = new Random();
numesatto = random.Next(1, 11);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Benvenuto a Trova il Numero! Per giocare, inserire il nome (3 lettere)");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("\nBenvenuto, ");
Console.WriteLine(nome + "!");

vite = 3;
Console.WriteLine("Devi indovinare il numero giusto, altrimenti perdi una vita!");
Console.WriteLine($"Hai a disposizione {vite} vite.\n");

while (vite != 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Ora inserisci un numero (niente 0 o negativi): ");
    num = int.Parse(Console.ReadLine());
    
    if (num == numesatto)
    {
        Console.WriteLine("Congratulazioni! Hai indovinato!");
        Console.WriteLine($"Il numero generato era: {numesatto}");
        break;
    }
    
    if (num != numesatto)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Errato! Ritenta");
        vite--;
    }

    if (vite == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nVite finite! GAME OVER");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Il numero da indovinare era: {numesatto}");
    }
}