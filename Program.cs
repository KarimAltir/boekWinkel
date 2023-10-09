namespace boekWinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boek boek1 = new Boek("123456789", "Het Boek", "Uitgeverij XYZ", 20);
            Boek boek2 = new Boek("987654321", "Een Ander Boek", "Uitgeverij ABC", 15);

            Tijdschrift tijdschrift1 = new Tijdschrift("111222333", "Maandblad", "Uitgeverij PQR", 5, Verschijningsperiode.Maandelijks);
            Tijdschrift tijdschrift2 = new Tijdschrift("444555666", "Weekblad", "Uitgeverij LMN", 3, Verschijningsperiode.Wekelijks);

            List<Bestelling<object>> bestellingen = new List<Bestelling<object>>();

            Bestelling<object> bestelling1 = new Bestelling<object>(boek1, 2);
            Bestelling<object> bestelling2 = new Bestelling<object>(tijdschrift2, 3, Verschijningsperiode.Wekelijks);

            bestelling1.BoekBesteld += (boodschap) => Console.WriteLine(boodschap);

            bestellingen.Add(bestelling1);
            bestellingen.Add(bestelling2);

            foreach (var bestelling in bestellingen)
            {
                bestelling.Bestel();
            }

            // Testen van prijsvalidatie
            boek1.Prijs = 55;

            Console.ReadKey();
        }
    }
}