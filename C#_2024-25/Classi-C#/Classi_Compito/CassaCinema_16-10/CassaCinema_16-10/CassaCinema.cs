using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassaCinema_16_10
{
    public class CassaCinema
    {
        private int bigliettiDisponibili;
        private double prezzoBiglietto;
        private List<string> vendite;

        public CassaCinema(int numTicket, double prezzoTicket)
        {
            bigliettiDisponibili = numTicket;
            prezzoBiglietto = prezzoTicket;
            this.vendite = new List<string>();
        }

        public CassaCinema(CassaCinema cassaCopia) // Costruttore di copia
        {
            this.bigliettiDisponibili = cassaCopia.bigliettiDisponibili;
            this.prezzoBiglietto = cassaCopia.prezzoBiglietto;
            this.vendite = new List<string>();
        }

        public int GetBiglietti() { return bigliettiDisponibili; }
        public double GetPrezzo() { return prezzoBiglietto; }
        public double vendiBiglietti(int numTicket)
        {
            if (numTicket <= 0)
            {
                Console.WriteLine("Numero di biglietti non valido!");
                return 0;
            }
            int bigliettiVenduti = Math.Min(numTicket, bigliettiDisponibili);
            bigliettiDisponibili -= bigliettiVenduti;

            double costoTot = bigliettiVenduti * prezzoBiglietto;

            if (bigliettiVenduti > 5) { costoTot *= 0.95; }

            vendite.Add($"Venduti {bigliettiVenduti} biglietti per un totale di {costoTot:F2} euro."); // F2 è utilizzato per indicare quanti numeri dopo la virgola
            Console.WriteLine($"Venduti {bigliettiVenduti} biglietti. Costo totale: {costoTot:F2} euro.");
            Console.WriteLine($"Numero biglietti rimasti: {bigliettiDisponibili}");
            return costoTot;
        }

        public void ricarica(int qt)
        {
            if (qt > 0)
            {
                bigliettiDisponibili += qt;
                Console.WriteLine($"Ricaricati {qt} biglietti. Biglietti totali disponibili: {bigliettiDisponibili}.");
            }

            else
            {
                Console.WriteLine("Quantità non valida!");
            }
        }

        public void stampaVendite()
        {
            if (vendite.Count == 0)
            {
                Console.WriteLine("Non sono state effettuate vendite.");
            }
            else
            {
                Console.WriteLine("Lista vendite:");
                foreach (var vendita in vendite)
                {
                    Console.WriteLine(vendita);
                }
            }
        }


    }

}
