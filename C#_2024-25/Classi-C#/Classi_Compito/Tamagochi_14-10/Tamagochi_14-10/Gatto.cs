using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_14_10
{
    public class Gatto
    {
        private int fame;
        private int sonno;
        private int felicita;
        private int pulizia;

        public Gatto()
        {
            fame = 50;
            sonno = 50;
            felicita = 50;
            pulizia = 50;
        }

        public int GetFame() { return fame; }
        public int GetSonno() { return sonno; }
        public int GetFelicita() { return felicita; }
        public int GetPulizia() { return pulizia; }

        public void stampaInfo()
        {
            Console.WriteLine($"Fame: {fame}");
            Console.WriteLine($"Sonno: {sonno}");
            Console.WriteLine($"Felicità: {felicita}");
            Console.WriteLine($"Pulizia: {pulizia}");
        }

        public void Mangia(string cibo)
        {
            if (fame >= 100)
            {
                Console.WriteLine("Il gatto è già sazio e non ha bisogno di mangiare al momento.");
                return; // Blocca la funzione se la fame è già al massimo
            }

            switch (cibo.ToLower())
            {
                case "crocchette":
                    fame = Math.Min(100, fame + 20);
                    pulizia = Math.Max(0, pulizia - 10);
                    break;
                case "pesce":
                    fame = Math.Min(100, fame + 30);
                    pulizia = Math.Max(0, pulizia - 15);
                    break;
                case "carne":
                    fame = Math.Min(100, fame + 40);
                    pulizia = Math.Max(0, pulizia - 25);
                    break;
                case "latte":
                    fame = Math.Min(100, fame + 10);
                    pulizia = Math.Max(0, pulizia - 5);
                    break;
                case "erba gatta":
                    felicita = Math.Min(100, felicita * 2);
                    pulizia = Math.Max(0, pulizia - 5);
                    break;
                default:
                    Console.WriteLine("Cibo non valido."); 
                    // La parola chiave predefinita è facoltativa e specifica del codice da eseguire se non esiste alcuna corrispondenza tra maiuscole e minuscole.
                    break;
            }
        }

        public void Dormi(int turni)
        {
            if (sonno >= 100)
            {
                Console.WriteLine("Il gatto è già completamente riposato e non ha bisogno di dormire.");
                return; // Blocca la funzione se il sonno è già al massimo
            }

            sonno = Math.Min(100, sonno + (turni * 10));
            fame = Math.Max(0, fame - (turni * 2));
        }

        public void Gioca(int turni)
        {
            felicita = Math.Min(100, felicita + (turni * 10));
            pulizia = Math.Max(0, pulizia - (turni * 5));
            sonno = Math.Max(0, sonno - (turni * 5));
            fame = Math.Max(0, fame - (turni * 3));
        }

        public void Lava()
        {
            if (pulizia >= 100)
            {
                Console.WriteLine("Il gatto è già perfettamente pulito. Non serve lavarlo.");
                return; // Blocca la funzione se la pulizia è già al massimo
            }

            pulizia = 100;
            felicita = Math.Max(0, felicita - 50); // Il gatto odia lavarsi :)
        }

        public bool ControllaGameOver()
        {
            if (fame <= 0)
            {
                Console.WriteLine("GAME OVER: Il gatto è morto di fame. E' tutta colpa tua...");
                return true;
            }
            else if (felicita <= 0)
            {
                Console.WriteLine("GAME OVER: Il tuo gatto è scappato, era infelice nella tua casa.");
                return true;
            }
            else if (sonno <= 0)
            {
                Console.WriteLine("GAME OVER: Il tuo gatto non si sveglia più a causa dell'insonnia.");
                return true;
            }
            else if (pulizia <= 0)
            {
                Console.WriteLine("GAME OVER: Il tuo gatto puzza talmente tanto che è morto asfissiato dalla stessa puzza.");
                return true;
            }
            return false;
        }
    }
}
