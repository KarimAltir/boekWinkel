namespace boekWinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boek boek1 = new Boek("123456789", "Harry poter", "De Harmonie", 20.5);
            Boek boek2 = new Boek("987654321", "Robin hood", "Andrew of Wyntoun", 15.0);

            Tijdschrift tijdschrift1 = new Tijdschrift("35838532", "Kuifje", "Casterman", 5.5, Verschijningsperiode.Maandelijks);
            Tijdschrift tijdschrift2 = new Tijdschrift("28462654", "The simpsons", "Matt Groening", 10, Verschijningsperiode.Wekelijks);

            List<Bestelling<object>> bestellingen = new List<Bestelling<object>>();

            Bestelling<object> bestelling1 = new Bestelling<object>(boek1, 2);
            Bestelling<object> bestelling2 = new Bestelling<object>(tijdschrift2, 3, Verschijningsperiode.Wekelijks);

            bestelling1.BoekBesteld += (naam) => Console.WriteLine("Boek met de naam " + naam + " is bestelt.");

            bestellingen.Add(bestelling1);
            bestellingen.Add(bestelling2);

            foreach (var bestelling in bestellingen)
            {
                bestelling.Bestel();
            }

            Console.ReadKey();
        }
    }
}