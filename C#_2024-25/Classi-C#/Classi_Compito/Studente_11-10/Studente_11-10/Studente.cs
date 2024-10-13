using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studente_11_10
{
    public class Studente
    {
        private string nome;
        private string cognome;
        private string matricola;
        private int annoIscr;
        private List<float> voti;

        public Studente(string n, string cn, string matr, int anno)
        {
            nome = n; cognome = cn; matricola = matr; annoIscr = anno;
            this.voti = new List<float>();
        }

        public string GetNome()
        {
            if (string.IsNullOrEmpty(nome)) { throw new Exception("Nome errato!"); }
            else
            {
                Console.WriteLine($"Nome: {nome}");
                return nome;
            }
        }

        public string GetCognome()
        {
            if (string.IsNullOrEmpty(cognome)) { throw new Exception("Cognome errato!"); }
            else
            {
                Console.WriteLine($"Cognome: {cognome}");
                return cognome;
            }
        }

        public string GetMatricola()
        {
            if (string.IsNullOrEmpty(matricola)) { throw new Exception("Matricola errato!"); }
            else
            {
                Console.WriteLine($"Matricola: {matricola}");
                return matricola;
            }
        }

        public int GetAnno()
        {
            if (annoIscr <= 0 && annoIscr > DateTime.Now.Year)
            {
                throw new Exception("Anno non valido!");
            }
            else
            {
                Console.WriteLine($"Anno iscrizione: {annoIscr}");
                return annoIscr;
            }
        }

        public void aggiungi(float voto)
        {
            if (voto >= 0 && voto <= 10)
            {
                voti.Add(voto);
                Console.WriteLine($"Voto aggiunto: {voto}");
            }
            else { throw new ArgumentException("Errore! Voto deve essere compreso tra 0 e 10!"); }
        }

        public float media()
        {
            if (voti.Count == 0) { throw new InvalidOperationException("Non ci sono voti!"); }

            float somma = 0;
            foreach (float voto in voti)
            {
                somma += voto;
            }
            return somma/voti.Count;
        }

        public void stampaDettagli()
        {
            GetNome();
            GetCognome();
            GetMatricola();
            GetAnno();

            if (voti.Count > 0)
            {
                Console.WriteLine($"Media voti: {media()}");
            }
            else
            {
                Console.WriteLine("Nessun voto inserito.");
            }
        }
    }
}
