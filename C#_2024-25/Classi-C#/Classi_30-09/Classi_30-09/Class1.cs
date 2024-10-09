using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchina
{
    /*
     * Inserisci il nome del giocatore 1
     * Inserisci il nome del giocatore 2
     * 
     * Vita player 1: ##########
     * Vita player 2: ##########
     * 
     * Tocca al player 1
     * Intensità ?
     * 
     * Vita player 1: ##########
     * Vita player 2: ########
     * 
     * Il player 1 si rompe il braccio dalla troppa potenza
     * 
     */

    public class Persona

    {
        // Attributi --> In C# sono semplicemente variabili

        /* Caso del public
 
        public string nome; 
        // Se private visibile solo all'interno della classe e non al di fuori, mentre public posso accedere anche nel programma principale
        public string cognome;
        public bool vivo;
        public float altezza;
        public int annoNascita;
        public int eta;
        public int num_animali; // Attributo non obbligatorio, quindi posso anche lasciarlo così
        */

        string nome; // Se non si mette nulla, è privato di default
        private string cognome;
        private bool vivo;
        private float altezza;
        private int annoNascita;
        private int eta;

        /*
        // Costruttore della classe (Metodo) --> Serve per inizializzare gli attributi (quindi assegnare un valore agli attributi)
        public Persona(string n, string c, float a, int annoNascita) // Parametri di funzione

        // Modificatore d'accesso (public, private) / Stesso nome della classe (Persona)
        // Posso metterlo davanti agli attributi ed ai metodi
        {
            nome = n; // Assegno l'attributo alle variabili del modificatore
            cognome = c;
            altezza = a;
            vivo = true;
            annoNascita = annoNascita; // Attributo e parametro hanno stesso nome. Cerca prima nell'ambito locale, poi nel globale se non c'è nel locale
        }
        */

        public Persona(string n, string c, float a, int annoNascita) // Parametri di funzione

        // Modificatore d'accesso (public, private) / Stesso nome della classe (Persona)
        // Posso metterlo davanti agli attributi ed ai metodi
        {
            nome = n; // Assegno l'attributo alle variabili del modificatore
            cognome = c;
            altezza = a;
            vivo = true;
            this.annoNascita = annoNascita; // Qui utilizza this --> Indica "me stesso", quindi assegno il MIO attributo dato (prende dagli attributi sopra)
            eta = DateTime.Now.Year - annoNascita; // DateTime.Now --> prende la data attuale

        }

        // Getter e Setter --> Properties 

        /*
         * Overloading di funzione
         
        public Persona(string n, string c, float a, int nad)
        {
            nome = n;
            cognome = c;
            altezza = a;
            num_animali = nad;
        }

        public Persona(string n, string c, int nad)
        {
            nome = n;
            cognome = c;
            altezza = a;
            num_animali = nad;
        }

        // Costruttore di default --> Costruttore che C# chiama quando non sa quale costruttore assegnare
        public Persona()
        {
            nome = "Gigi";
            cognome = "Buffon";
            altezza = 190;
            num_animali = 0;
        }
        */

        // Metodi
        public void saluta() // Importante mettere il public altrimenti non si può usare il metodo
        {
            Console.WriteLine("Ciao!");
        }

        public void spacca_noci_con_gomito()
        {
            Console.WriteLine("CRACK");
            Random random = new Random();
            int p = random.Next(1, 10);

            if (p <= 5)
            {
                Console.WriteLine("Tremon de merda sei morto");
                vivo = false;
            }

            else
            {
                Console.WriteLine("Sei vivo bro e hai pure la noce :D");
                vivo = true;
            }

        }

        // Campo (o attributo) calcolato --> Metodi che restituiscono delle funzioni
        public int getEta()
        {
            return DateTime.Now.Year - annoNascita;
        }

        public int getAnnoNascita()
        {
            return annoNascita;
        }

        public string getNominativo()
        {
            return nome + " " + cognome;
        }

    }

}
