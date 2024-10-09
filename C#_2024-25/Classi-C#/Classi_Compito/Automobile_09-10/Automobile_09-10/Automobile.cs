using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_09_10
{
    public class Automobile
    {
        private string marca;
        private string modello;
        private int anno;
        private float kilometri;

        public Automobile(string mar, string mod, int a, float km) 
        {
            marca = mar;
            modello = mod;
            anno = a;
            kilometri = km;
        }

        public string GetMarca() 
        {
            if (string.IsNullOrEmpty(marca) == true) { throw new ArgumentException("Marca non valida!"); }
           
            else
            {
                Console.WriteLine($"Marca: {marca}");
                return marca;
            }
        }
        public string GetModello()
        {
            if (string.IsNullOrEmpty(modello) == true) { throw new ArgumentException("Modello non valido!"); }
            else
            {
                Console.WriteLine($"Modello: {modello}");
                return modello;
            }

        }
        public int GetAnno()
        {
            int year = DateTime.Now.Year;
            if (anno <= 0 || anno > year) { throw new ArgumentException("Anno non valido!"); }
            else
            {
                Console.WriteLine($"Anno: {anno}");
                return anno;
            }
        }
        public float GetKilometri()
        {
            if (kilometri < 0 || kilometri > 500000) { throw new ArgumentException("Anno non valido!"); }
            else
            {
                Console.WriteLine($"Chilometraggio: {kilometri}");
                return kilometri;
            }
        }

        public void stampaAuto()
        {
            GetMarca();
            GetModello();
            GetAnno();
            GetKilometri();

        }

        public void aggiornaKM(float nuovoKM)
        {
            if (nuovoKM >= kilometri)
            {
                kilometri = nuovoKM;
                stampaAuto();
            }

            else
            {
                Console.WriteLine("Errore! Il nuovo chilometraggio non può essere inferiore a quello attuale!");
            }
        }

        public int calcolaEta()
        {
            int year = DateTime.Now.Year;
            return year - anno;
        }
    }
}
