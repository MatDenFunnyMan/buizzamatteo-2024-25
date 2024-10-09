using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisione_09_10
{
    public class Televisione
    {
        private string marca;
        private string modello;
        private int numMaxCanali;
        private int volMin;
        private int volMax;
        private bool aColore;

        // Stati interni
        private bool accesa;
        private int canaleCorrente;
        private int volCorrente;

        public Televisione(string mar, string mod, bool aColor)
        {
            marca = mar;
            modello = mod;
            numMaxCanali = 100;
            volMin = 0;
            volMax = 50;
            aColore = aColor;
            accesa = false;
            canaleCorrente = 1;
            volCorrente = volMin;
        }

        public Televisione(string mar, string mod, int maxCanali, int vMin, int vMax, bool aColor)
        {
            marca = mar;
            modello = mod;
            numMaxCanali = maxCanali;
            volMin = vMin;
            volMax = vMax;
            aColore = aColor;
            accesa = false;
            canaleCorrente = 1;
            volCorrente = volMin;
        }

        public string GetMarca()
        {
            if (string.IsNullOrWhiteSpace(marca)) { throw new Exception("Marca non valida!"); }
            else
            {
                Console.WriteLine($"Marca TV: {marca}");
                return marca;
            }
        }

        public string GetModello()
        {
            if (string.IsNullOrWhiteSpace(modello)) { throw new Exception("Modello non valido!"); }
            else
            {
                Console.WriteLine($"Modello TV: {modello}");
                return modello;
            }
        }

        public int GetNumCanali()
        {
            if (numMaxCanali < 0) { throw new Exception("Numero canali non valido!"); }
            else
            {
                Console.WriteLine($"Num massimo canali TV: {numMaxCanali}");
                return numMaxCanali;
            }
        }

        public int GetVolMin()
        {
            if (volMin < 0 || volMin > 100) { throw new Exception("Volume minimo non valido!"); }
            else
            {
                Console.WriteLine($"Volume minimo TV: {volMin}");
                return volMin;
            }
        }

        public int GetVolMax()
        {
            if (volMax < 0 || volMax > 100) { throw new Exception("Volume minimo non valido!"); }
            else
            {
                Console.WriteLine($"Volume massimo TV: {volMax}");
                return volMax;
            }
        }

        public bool GetColore()
        {
            if (aColore == false) { Console.WriteLine("TV bianco e nero"); }
            else
            {
                Console.WriteLine("TV a colore");
            }
            return aColore;
        }

        public void accendi()
        {
            accesa = true;
            Console.WriteLine("TV accesa");
        }

        public void spegni()
        {
            accesa = false;
            Console.WriteLine("TV spenta");
        }

        public bool isAccesa()
        {
            return accesa;
        }

        public void alzaVolume1()
        {
            if (accesa)
            {
                volCorrente += 1;
                if (volCorrente > volMax) { volCorrente = volMax; }
                Console.WriteLine($"Volume alzato a {volCorrente}");
            }
            else
            {
                Console.WriteLine("Impossibile alzare il volume. La TV è spenta!");
            }
        }
        public void abbassaVolume1()
        {
            if (accesa)
            {
                volCorrente -= 1;
                if (volCorrente > volMax) { volCorrente = volMax; }
                Console.WriteLine($"Volume abbassato a {volCorrente}");
            }
            else
            {
                Console.WriteLine("Impossibile abbassare il volume. La TV è spenta!");
            }
        }

        public void alzaVolume(int n)
        {
            if (accesa)
            {
                volCorrente += n;
                if (volCorrente > volMax) { volCorrente = volMax; }
                Console.WriteLine($"Volume alzato a {volCorrente}");
            }
            else
            {
                Console.WriteLine("Impossibile alzare il volume. La TV è spenta!");
            }
        }

        public void abbassaVolume(int n)
        {
            if (accesa)
            {
                volCorrente -= n;
                if (volCorrente > volMax) { volCorrente = volMax; }
                Console.WriteLine($"Volume abbassato a {volCorrente}");
            }
            else
            {
                Console.WriteLine("Impossibile abbassare il volume. La TV è spenta!");
            }
        }

        public void incrementaCanale()
        {
            if (accesa)
            {
                canaleCorrente++;
                if (canaleCorrente > numMaxCanali) { canaleCorrente = 1; }
                Console.WriteLine($"Canale impostato a {canaleCorrente}");
            }
            else
            {
                Console.WriteLine("Impossibile cambiare. La TV è spenta!");
            }
        }

        public void decrementaCanale()
        {
            if (accesa)
            {
                canaleCorrente--;
                if (canaleCorrente < 1) { canaleCorrente = numMaxCanali; }
                Console.WriteLine($"Canale impostato a {canaleCorrente}");
            }
            else
            {
                Console.WriteLine("Impossibile cambiare. La TV è spenta!");
            }
        }

        public void stampaInfo()
        {
            GetMarca();
            GetModello();
            GetNumCanali();
            GetVolMin();
            GetVolMax();
            GetColore();

        }
    }
}
