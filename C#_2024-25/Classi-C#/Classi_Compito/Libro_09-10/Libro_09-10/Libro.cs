using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_09_10
{
    public class Libro
    {
        // Attributi

        private string titolo;
        private string autore;
        private int numPagine;
        private string genere;
        private bool raccolta;

        public Libro(string tt, string aut, int nPag, string genre, bool racc)
        {
            titolo = tt;
            autore = aut;
            numPagine = nPag;
            genere = genre;
            raccolta = racc;
        }

        public string GetTitolo()
        {
            if (string.IsNullOrWhiteSpace(titolo) == true) { throw new Exception("Titolo non valido!"); }
            else
            {
                Console.WriteLine($"Titolo libro: {titolo}");
                return titolo;
            }
        }

        public string GetAutore()
        {
            if (string.IsNullOrWhiteSpace(autore) == true) { throw new Exception("Autore non valido!"); }
            else
            {
                Console.WriteLine($"Autore libro: {autore}");
                return autore;
            }
        }

        public int GetNumPag()
        {
            if (numPagine <= 0 || numPagine > 500) { throw new Exception("Numero pagine non valido!"); }
            else
            {
                Console.WriteLine($"Num pagine libro: {numPagine}");
                return numPagine;
            }
        }

        public string GetGenere()
        {
            if (string.IsNullOrWhiteSpace(genere) == true) { throw new Exception(); }
            else
            {
                Console.WriteLine($"Genere libro: {genere}");
                return genere;
            }
        }

        public bool GetRaccolta()
        {
            if (raccolta == false) { Console.WriteLine("Il libro non fa parte di una raccolta"); }
            else
            {
                Console.WriteLine("Il libro fa parte di una raccolta");
            }
            return raccolta;
        }

        public void stampaInfoLibro()
        {
            GetTitolo();
            GetAutore();
            GetNumPag();
            GetGenere();
            GetRaccolta();
        }
    }
}
