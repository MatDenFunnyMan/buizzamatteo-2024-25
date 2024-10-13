using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furgone_11_09
{
    public class Furgone
    {
        // Attributi
        private int capienza;
        private int spazio;

        public Furgone(int capIni)
        {
            if (capIni <= 0) { throw new ArgumentException("La capienza deve essera positiva!"); }
            capienza = capIni;
            spazio = 0;
        }

        public void caricaPiccolo()
        {
            caricaScatolone(1, "Piccolo");
        }

        public void caricaMedio()
        {
            caricaScatolone(2, "Medio");
        }

        public void caricaGrande()
        {
            caricaScatolone(3, "Grande");
        }

        private void caricaScatolone(int unit, string tipo)
        {
            if (spazio + unit > capienza)
            {
                Console.WriteLine($"Non c'è abbastanza spazio per caricare uno scatolone {tipo}");
            }
            else
            {
                spazio += unit;
                Console.WriteLine($"Scatolone {tipo} caricato. Spazio occupato: {spazio}");
            }
        }

        public void scaricaCarico()
        {
            Console.WriteLine($"Scaricamento del camion. Spazio occupato prima dello scarico: {spazio} unità.");
            spazio = 0;
            Console.WriteLine("Camion scaricato con successo!");
        }

        public int GetSpazioRim()
        {
            int spazioRim = capienza - spazio;
            Console.WriteLine($"Spazio rimanente sul furgone: {spazioRim} unità.");
            return spazioRim;
        }

        public int CalcoloCostoSpediz()
        {
            int costo = spazio * 10;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Costo totale della spedizione: {costo:C}.");
            return costo;

        }

        public void StampaInfoFurgone()
        {
            Console.WriteLine(" ");
            Console.WriteLine("=== Informazioni Furgone ===");
            Console.WriteLine($"Capienza totale/massima: {capienza} unità.");
            Console.WriteLine($"Spazio occupato: {spazio} unità.");
            GetSpazioRim();
            CalcoloCostoSpediz();
            Console.WriteLine("===========================\n");
        }
    }
}
