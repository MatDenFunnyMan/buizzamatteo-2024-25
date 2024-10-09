namespace Automobile_09_10
{
    class Program
    {
        public static void Main()
        {
            Automobile auto1 = new Automobile("Ford", "Fiesta", 2020, 15000);

            Console.WriteLine("Dettagli dell'auto:");
            auto1.stampaAuto();

            int eta = auto1.calcolaEta();
            Console.WriteLine($"L'automobile ha {eta} anni");

            Console.Write("Inserisci nuovo chilometraggio: ");
            float kmNuovo = float.Parse(Console.ReadLine());
            auto1.aggiornaKM(kmNuovo); // Nuova stampa già inserita
        }
    }
}
