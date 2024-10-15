using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentraleElettrica_16_10
{
    public class Utilizzatore
    {
        public string nome;
        public int consumo;
        
        public Utilizzatore(string n, int c)
        {
            nome = n;
            consumo = c;
        }
    }

    public class CentraleElettrica
    {
        private int energiaTotale;
        private int energiaUso;
        private List<Utilizzatore> utilizzatoriConnessi;

        public CentraleElettrica(int energiaTot)
        {
            this.energiaTotale = energiaTot;
            this.energiaUso = 0;
            this.utilizzatoriConnessi = new List<Utilizzatore>();
        }

        public CentraleElettrica(CentraleElettrica centraleCopia)
        {
            this.energiaTotale = centraleCopia.energiaTotale;
            this.energiaUso = 0;
            this.utilizzatoriConnessi = new List<Utilizzatore>();
        }

        public int GetEnergiaDispoibile() { return energiaTotale - energiaUso; }
        public int GetEnergiaUso() { return energiaUso; }

        public bool collegaUtilizzatore(Utilizzatore utilizzatore)
        {
            if (utilizzatore.consumo <= GetEnergiaDispoibile())
            {
                utilizzatoriConnessi.Add(utilizzatore);
                energiaUso += utilizzatore.consumo;
                Console.WriteLine($"Utilizzatore {utilizzatore.nome} collegato. Consumo: {utilizzatore.consumo} unità.");
                return true;
            }
            else
            {
                Console.WriteLine($"Utilizzatore {utilizzatore.nome} non collegato. Richiede {utilizzatore.consumo} unità, ma ne rimangono solo {GetEnergiaDispoibile()}.");
                return false;
            }
        }

        public void scollegaUtilizzatore(Utilizzatore utilizzatore)
        {
            if (utilizzatoriConnessi.Remove(utilizzatore))
            {
                energiaUso -= utilizzatore.consumo;
                Console.WriteLine(($"Utilizzatore {utilizzatore.nome} scollegato. Consumo liberato: {utilizzatore.consumo} unità."));
            }
            else
            {
                Console.WriteLine($"Utilizzatore {utilizzatore.nome} non trovato.");
            }
        }

        public void stampaUtilizzatori()
        {
            if (utilizzatoriConnessi.Count == 0)
            {
                Console.WriteLine("Nessun utilizzatore è connesso.");
            }
            else
            {
                Console.WriteLine("Utilizzatori connessi:");
                foreach (var utilizzatore in utilizzatoriConnessi)
                {
                    Console.WriteLine($"{utilizzatore.nome} | {utilizzatore.consumo} unità");
                }
            }
        }

    }

}
