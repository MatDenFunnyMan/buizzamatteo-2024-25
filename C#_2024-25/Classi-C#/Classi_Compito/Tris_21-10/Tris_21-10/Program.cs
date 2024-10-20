using Tris_21_10;

Tris gioco = new Tris();
bool continua = true;

while (continua)
{
    gioco.mostraIstruzioni();
    gioco.pulisci();

    bool partitaInCorso = true;
    while (partitaInCorso)
    {
        gioco.turnoGiocatore();

        if (gioco.vincita() != ' ')
        {
            partitaInCorso = false;
        }

        else if (gioco.pareggio())
        {
            partitaInCorso = false;
        }
    }

    Console.WriteLine("Vuoi rigiocare? (s/n): ");
    string risposta = Console.ReadLine();

    if (risposta.ToLower() != "s")
    {
        continua = false;
        Console.WriteLine("Grazie per aver giocato a Tris#!");
    }
}

