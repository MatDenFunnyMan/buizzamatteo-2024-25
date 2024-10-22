using System;

/* Alcune parti del codice avranno questo simbolo: *?
 * Questo perchè ci sono delle cose che considero importanti da spiegare/approfondire. 
 * In fondo al codice trovate descrizione di tali righe e che cosa fanno.
 */

namespace Tris_21_10
{
    public class Tris
    {
        private char[] scacchiera;
        private char giocatore;
        private char simboloGiocatore;
        private char simboloBot;

        public Tris()
        {
            scacchiera = new char[9];
            pulisci();
        }

        public void impostaSimboli(char simboloP1, char simboloCPU)
        {
            simboloGiocatore = simboloP1;
            simboloBot = simboloCPU;
            giocatore = simboloGiocatore;
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

        public char vincita()
        {
            // Possibili combinazioni vincenti
            int[,] combinazioniVincenti = new int[,]
            {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Righe
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Colonne
            { 0, 4, 8 }, { 2, 4, 6 }              // Diagonali
            };

            // Controllo combinazioni vincenti
            for (int i = 0; i < combinazioniVincenti.GetLength(0); i++)
            {
                if (scacchiera[combinazioniVincenti[i, 0]] != ' ' &&
                    scacchiera[combinazioniVincenti[i, 0]] == scacchiera[combinazioniVincenti[i, 1]] &&
                    scacchiera[combinazioniVincenti[i, 1]] == scacchiera[combinazioniVincenti[i, 2]])
                {
                    return scacchiera[combinazioniVincenti[i, 0]]; // Ritorna il simbolo vincente
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
            while(!mossaValida) // Scrittura alternativa per "mossaValida == false, perchè ! inverte la condizione, cioè se era true, con ! diventa false"
            {
                Console.Write($"Tocca al giocatore {giocatore}. Inserisci una posizione (1-9): ");
                string input = Console.ReadLine();
                int pos;

                if (int.TryParse(input, out pos))
                {
                    if (pos >= 1 && pos <= 9)
                    {

                        try
                        {
                            mossaValida = posiziona(simboloGiocatore, pos - 1);
                            Console.WriteLine(visualizza());

                            if (vincita() != ' ')
                            { 
                                return;
                            }

                            if (pareggio())
                            {
                                Console.WriteLine("La partita è finita in pareggio!");
                                return;
                            }
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Errore! Input non valido!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inserisci un numero valido tra 1 e 9.");
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Inserisci un numero intero.");
                }
            }
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

    /* Approfondimenti
     * 
     * 1.  public string visualizza()
     * Crea righe con tre elementi per riga (dall'array scacchiera).
     * Aggiunge separatori tra le righe per rendere visivamente chiara la scacchiera.
     * Restituisce una stringa formattata per rappresentare la scacchiera in modo leggibile.
     * 
     * Esempio
     * 
     *  X | O |  
     *  --|---|--
     *    | X |  
     *  --|---|--
     *  O |   | X
     *  
     *  2. private void cambiaTurno()
     *  
     *  Il metodo utilizza l'operatore ternario in C#. 
     *  L'operatore ternario è una scorciatoia per un'istruzione if-else e si usa nel formato:
     *  
     *  "condizione ? valore_se_vero : valore_se_falso;" (In questo caso: "giocatore = (giocatore == 'X') ? 'O' : 'X';")
     *  
     *  L'operatore ternario consente di scrivere condizioni in modo più compatto e leggibile rispetto a un classico if-else. 
     *  In questo caso, permette di cambiare rapidamente il giocatore attuale con una sola riga di codice.
     *  
     *  Senza l'operatore ternario, potresti scrivere lo stesso codice in questo modo:
     *  
     *  private void cambiaTurno()
        {
            if (giocatoreCorrente == 'X')
            {
                giocatoreCorrente = 'O';
            }
            else
            {
                giocatoreCorrente = 'X';
            }
        }
     *  
     */
}
