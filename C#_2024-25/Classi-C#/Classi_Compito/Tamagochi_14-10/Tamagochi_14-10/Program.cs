using Tamagochi_14_10;

Console.Write("Inserisci il nome del tuo gatto: ");
string nomeGatto = Console.ReadLine();
Gatto gatto1 = new Gatto();

List<string> cibi = new List<string>() { "Crocchette", "Pesce", "Carne", "Latte", "Erba Gatta" };

int turno = 1;
bool giocoAttivo = true;

while (giocoAttivo)
{
    Console.WriteLine($"\nTURNO {turno}");
    gatto1.stampaInfo();
    Console.WriteLine("Cosa vuoi fare?");
    Console.WriteLine("0) Passo");
    Console.WriteLine("1) Mangia");
    Console.WriteLine("2) Dormi");
    Console.WriteLine("3) Gioca");
    Console.WriteLine("4) Lava");

    int scelta = int.Parse(Console.ReadLine());

    switch (scelta)
    {
        case 0:
            Console.WriteLine("Hai deciso di passare il turno.");
            break;
        case 1:
            Console.WriteLine("Scegli cosa dare da mangiare: " + string.Join(", ", cibi));
            string cibo = Console.ReadLine();
            gatto1.Mangia(cibo);
            break;
        case 2:
            Console.WriteLine("Per quanti turni vuoi far dormire il gatto?");
            int turniDormire = int.Parse(Console.ReadLine());
            for (int i = 0; i < turniDormire; i++)
            {
                Console.WriteLine($"Stai dormendo (Turno {turno})...");
                gatto1.Dormi(1);
                turno++;
            }
            break;
        case 3:
            Console.WriteLine("Per quanti turni vuoi far giocare il gatto?");
            int turniGiocare = int.Parse(Console.ReadLine());
            gatto1.Gioca(turniGiocare);
            break;
        case 4:
            gatto1.Lava();
            Console.WriteLine("Hai lavato il gatto, ma non gli è piaciuto tanto :)");
            break;
        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }

    if (gatto1.ControllaGameOver())
    {
        giocoAttivo = false; // Termina il gioco
        break;
    }

    turno++;
}