using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1_11_10
{
    public class Formula1
    {
        private string scuderia;
        private string coloreLivrea;
        private float carburante;
        private float usuraGomme;
        private float capienzaSerbatoio;
        private string tipoGomme;
        private float kmPercorsi;

        public Formula1(string scud, string coloLiv, string gomme, float capacità)
        {
            if (string.IsNullOrEmpty(scud)) { throw new ArgumentException("Scuderia non valida!"); }
            if (string.IsNullOrEmpty(coloLiv)) { throw new ArgumentException("Colore livrea non valido!"); }
            if (string.IsNullOrEmpty(gomme) ||
                !(gomme.Equals("Deluxe", StringComparison.OrdinalIgnoreCase) ||
                gomme.Equals("Medie", StringComparison.OrdinalIgnoreCase) ||
                gomme.Equals("Povery", StringComparison.OrdinalIgnoreCase)))
            { throw new ArgumentException("Tipo gomme non valido! Può essere solo Deluxe, Medie o Povery."); }
            if (capacità <= 0)
            { throw new ArgumentException("Capienza serbatoio deve essere maggiore di zero!"); }

            scuderia = scud;
            coloreLivrea = coloLiv;
            tipoGomme = gomme;
            capienzaSerbatoio = capacità;
            carburante = capacità;
            this.usuraGomme = 0;
            this.kmPercorsi = 0;

        }

        public string GetScuderia()
        {
            Console.WriteLine($"Scuderia: {scuderia}");
            return scuderia;
        }

        public string GetColoreLivrea()
        {
            Console.WriteLine($"Colore livrea: {coloreLivrea}");
            return coloreLivrea;
        }

        public string GetTipoGomme()
        {
            Console.WriteLine($"Tipo gomme: {tipoGomme}");
            return tipoGomme;
        }

        public float GetCapienzaSerbatoio()
        {
            Console.WriteLine($"Capienza serbatorio: {capienzaSerbatoio} litri");
            return capienzaSerbatoio;
        }

        public float GetCarburante()
        {
            Console.WriteLine($"Livello carburante: {carburante} litri");
            return carburante;
        }

        public float GetUsuraGomme()
        {
            Console.WriteLine($"Livello usura gomme: {usuraGomme}");
            return usuraGomme;
        }

        public float GetKMPercorsi()
        {
            Console.WriteLine($"KM percorsi: {kmPercorsi} km");
            return kmPercorsi;
        }

        public bool percorri(float km)
        {
            if (km <= 0)
            {
                Console.WriteLine("I chilometri da percorrere devono essere maggiori di 0!");
                return false;
            }

            float consumo = km * 0.1f;
            float usuraG = calcolaUsura(km);

            if (carburante < consumo)
            {
                Console.WriteLine("Carburante insufficiente per percorrere la distanza richiesta.");
                return false;
            }

            if (usuraGomme + usuraG > 100)
            {
                Console.WriteLine("Le gomme non sono in buono stato per percorrere la distanza richiesta.");
                return false;
            }

            carburante -= consumo;
            usuraGomme += usuraG;
            kmPercorsi += km;

            Console.WriteLine($"Hai percorso {km} km.");
            return true;

        }

        private float calcolaUsura(float km)
        {
            float usuraKM = 0;
            switch (tipoGomme.ToLower())
            {
                case "deluxe":
                    usuraKM = 0.2f;
                    break;
                case "medie":
                    usuraKM = 0.5f;
                    break;
                case "povery":
                    usuraKM = 1.0f;
                    break;
            }
            return usuraKM * km;
        }

        public void cambiaGomme()
        {
            usuraGomme = 0;
            Console.WriteLine("Le gomme sono state cambiate e l'usura è stata resettata a 0.");
        }

        public void rifornisciCarburante(float qt)
        {
            if (qt <= 0)
            {
                throw new Exception("La quantità di carburante deve essere maggiore di zero.");
            }

            if (carburante + qt > capienzaSerbatoio)
            {
                Console.WriteLine($"Non puoi superare la capienza del serbatoio ({capienzaSerbatoio} litri). Rifornisco solo la quantità possibile.");
                carburante = capienzaSerbatoio;
            }
            else
            {
                carburante += qt;
                Console.WriteLine($"Hai rifornito {qt} litri di carburante.");
            }
        }

        public bool consigliaCambioGomme()
        {
            return usuraGomme >= 70;
        }

        public bool consigliaRifornimento()
        {
            return carburante <= (0.2f * capienzaSerbatoio);
        }

        public void visualizzaDati()
        {
            Console.WriteLine($"--- Dati Automobile ---");
            Console.WriteLine($"Scuderia: {scuderia}");
            Console.WriteLine($"Colore Livrea: {coloreLivrea}");
            Console.WriteLine($"Tipo Gomme: {tipoGomme}");
            Console.WriteLine($"Capienza Serbatoio: {capienzaSerbatoio} litri");
            Console.WriteLine($"Livello Carburante: {carburante} litri");
            Console.WriteLine($"Livello Usura Gomme: {usuraGomme}");
            Console.WriteLine($"Km Percorsi: {kmPercorsi} km");
            Console.WriteLine($"Consiglia Cambio Gomme: {(consigliaCambioGomme() ? "SI" : "NO")}");
            Console.WriteLine($"Consiglia Rifornimento: {(consigliaRifornimento() ? "SI" : "NO")}");
            Console.WriteLine("------------------------");
        }
    }
}
