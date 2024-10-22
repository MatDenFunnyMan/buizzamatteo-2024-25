using Tris_21_10;

Tris gioco = new Tris();
Computer bot = new Computer(gioco);

bool continua = true;

while (continua)
{

    char simboloGiocatore = ' ';
    bool inputValido = false;

    while (!inputValido)
    {
        Console.WriteLine("Che simbolo vuoi assegnarti? 'X' o 'O'? (il bot avrà l'altro simbolo): ");
        string input = Console.ReadLine().ToUpper();

        if (char.TryParse(input, out simboloGiocatore) && (simboloGiocatore == 'X' || simboloGiocatore == 'O'))
        {
            inputValido = true;
        }
        else
        {
            Console.WriteLine("Input non valido. Inserisci 'X' o 'O'.");
        }
    }

    bot.assegnaSimbolo(simboloGiocatore);

    gioco.mostraIstruzioni();
    gioco.pulisci();

    bool partitaInCorso = true;
    while (partitaInCorso)
    {
        gioco.turnoGiocatore();

        if (gioco.vincita() != ' ')
        {
            Console.WriteLine($"Il giocatore {simboloGiocatore} ha vinto!");
            partitaInCorso = false;
        }

        else if (gioco.pareggio())
        {
            partitaInCorso = false;
        }

        else
        {
            bot.faiMossa();

            if (gioco.vincita() != ' ')
            {
                Console.WriteLine($"Il bot ha vinto!");
                partitaInCorso = false;
            }

            else if (gioco.pareggio())
            {
                partitaInCorso = false;
            }
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

