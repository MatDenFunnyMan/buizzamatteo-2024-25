namespace Tris_21_10
{
    public class Computer
    {
        private char simbolocpu;
        private Tris partita;
    
        public Computer(Tris game)
        {
            partita = game;
        }

        public void assegnaSimbolo(char simboloGiocatore)
        {
            if (simboloGiocatore == 'X')
            {
                simbolocpu = 'O';
            }
            else
            {
                simbolocpu = 'X';
            }

            partita.impostaSimboli(simboloGiocatore, simbolocpu);

        }

        public void faiMossa()
        {
            Random rnd = new Random();
            bool mossaValida = false;

            do
            {
                int pos = rnd.Next(0, 9);

                try
                {
                    mossaValida = partita.posiziona(simbolocpu, pos);
                    Console.WriteLine($"Il bot ha piazzato {simbolocpu} in posizione {pos + 1}");
                    Console.WriteLine(partita.visualizza());
                }
                catch (InvalidOperationException) { }

            } while (!mossaValida);
        }    
    }
}
