using System;

/* Alcune parti del codice avranno questo simbolo: *?
 * Questo perchè ci sono delle cose che considero importanti da spiegare/approfondire. 
 * In fondo al codice trovate descrizione di tali righe e che cosa fanno.
 */

namespace Tris_ArraySingolo
{
    public class Tris
    {
        private char[] scacchiera;
        private char giocatore;

        public Tris()
        {
            scacchiera = new char[9];
            pulisci();
            giocatore = 'X';
        }

        public bool posiziona(char simbolo, int pos)
        {
            if (verificaMossa(pos))
            {
                scacchiera[pos] = simbolo;
                return true;
            }
            return false;
        }

        public void pulisci()
        {
            for (int i = 0; i < 9; i++)
            {
                scacchiera[i] = ' ';
            }
        }

        public string visualizza() // *?
        {
            string output = "";
            for (int i = 0; i < 9; i += 3)
            {
                output += $"{scacchiera[i]} | {scacchiera[i + 1]} | {scacchiera[i + 2]}\n";
                if (i < 6) output += "--|---|--\n";
            }
            return output;
        }

        private bool verificaMossa(int pos)
        {
            if (pos < 0 || pos >= 9) throw new ArgumentOutOfRangeException("Posizione fuori dai limiti della scacchiera.");
            if (scacchiera[pos] != ' ') throw new InvalidOperationException("Posizione già occupata.");
            return true;
        }

        public char vincita() // Da private a public
        {
            int[] combinazioniVincenti = new int[]
            {
            0, 1, 2,  // Prima riga
            3, 4, 5,  // Seconda riga
            6, 7, 8,  // Terza riga
            0, 3, 6,  // Prima colonna
            1, 4, 7,  // Seconda colonna
            2, 5, 8,  // Terza colonna
            0, 4, 8,  // Diagonale principale
            2, 4, 6   // Diagonale secondaria
            };

            for (int i = 0; i < combinazioniVincenti.Length; i += 3)
            {
                if (scacchiera[combinazioniVincenti[i]] != ' ' &&
                    scacchiera[combinazioniVincenti[i]] == scacchiera[combinazioniVincenti[i + 1]] &&
                    scacchiera[combinazioniVincenti[i + 1]] == scacchiera[combinazioniVincenti[i + 2]])
                {
                    return scacchiera[combinazioniVincenti[i]]; // Ritorna il simbolo vincente
                }
            }

            return ' '; // Nessuna vincita
        }

        public bool pareggio()
        {
            foreach (char cella in scacchiera)
            {
                if (cella == ' ')
                {
                    return false; // Se ci sono ancora celle vuote, non è un pareggio
                }
            }
            return vincita() == ' '; // Se tutte le celle sono piene e non c'è un vincitore, è pareggio
        }

        public void turnoGiocatore()
        {
            bool mossaValida = false;
            while (!mossaValida) // Scrittura alternativa per "mossaValida == false, perchè ! inverte la condizione, cioè se era true, con ! diventa false"
            {
                Console.WriteLine($"Tocca al giocatore {giocatore}. Inserisci una posizione (0-8): ");
                int pos = int.Parse(Console.ReadLine());

                try
                {
                    mossaValida = posiziona(giocatore, pos);
                    Console.WriteLine(visualizza());

                    if (vincita() != ' ')
                    {
                        Console.WriteLine($"Il giocatore {giocatore} ha vinto!");
                        return;
                    }

                    if (pareggio())
                    {
                        Console.WriteLine("La partita è finita in pareggio!");
                        return;
                    }

                    cambiaTurno();
                }

                catch (Exception)
                {
                    Console.WriteLine("Errore! Input non valido!");
                }
            }
        }

        private void cambiaTurno()
        {
            giocatore = (giocatore == 'X') ? 'O' : 'X'; // *?
        }

        public void mostraIstruzioni()
        {
            Console.WriteLine("BENVENUTO A TRIS#");
            Console.WriteLine("Istruzioni:");
            Console.WriteLine("1. Il gioco si svolge su una scacchiera 3x3.");
            Console.WriteLine("2. Due giocatori si alternano inserendo 'X' o 'O' in una delle 9 posizioni.");
            Console.WriteLine("3. Per fare una mossa, inserisci un numero da 0 a 8 che rappresenta la posizione sulla scacchiera.");
            Console.WriteLine("4. Vince il primo giocatore che riesce a mettere tre simboli in fila, colonna o diagonale.");
            Console.WriteLine("5. Se tutte le posizioni sono occupate senza un vincitore, la partita finisce in pareggio.");
            Console.WriteLine();
        }

    }
}