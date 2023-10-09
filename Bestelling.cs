using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boekWinkel
{
    enum Verschijningsperiode
    {
        Dagelijks,
        Wekelijks,
        Maandelijks
    }
    public class Bestelling<T>
    {
        private static int volgnummer = 1;
        public int Id { get; }
        public T Item { get; }
        public DateTime Datum { get; }
        public int Aantal { get; set; }
        public Verschijningsperiode? AbonnementPeriode { get; set; }

        public Bestelling(T item, int aantal, Verschijningsperiode? periode = null)
        {
            Id = volgnummer++;
            Item = item;
            Datum = DateTime.Now;
            Aantal = aantal;
            AbonnementPeriode = periode;
        }

        public Tuple<string, int, double> Bestel()
        {
            double totalePrijs = 0;

            if (Item is Boek boek)
            {
                totalePrijs = boek.Prijs * Aantal;
                Console.WriteLine("Boek met ISBN " + boek.Isbn + " (" + boek.Naam + ") is besteld. Aantal: " + Aantal + " Totale prijs: " + totalePrijs + "€");
            }
            else if (Item is Tijdschrift tijdschrift)
            {
                totalePrijs = tijdschrift.Prijs * Aantal;
                Console.WriteLine("Tijdschrift met ISBN " + tijdschrift.Isbn + " (" + tijdschrift.Naam + ") is besteld. Aantal: " + Aantal + ", Totale prijs: " + totalePrijs + "€, Verschijningsperiode: " + tijdschrift.Periode + ")");
            }

            return new Tuple<string, int, double>(Id.ToString(), Aantal, totalePrijs);
        }

        public event Action<string> BoekBesteld;

        public void BoekBestellingBevestigen()
        {
            if (Item is Boek boek)
            {
                BoekBesteld?.Invoke("Boek met ISBN " + boek.Isbn + " (" + boek.Naam + ") is besteld.");
            }
        }
    }
}
