using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boekWinkel
{
    public class Boek
    {
        public string Isbn {  get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        public double prijs;
        public double Prijs 
        { 
            get {  return prijs; } 
            set
            {
                if (value >= 5 && value <= 50)
                {
                    prijs = value;
                } else
                {
                    Console.WriteLine("De prijs van " + Naam + " moet tussen 5€ en 50€ zijn, de prijs is " + prijs);
                }
            } 
        }

        public Boek(string isbn, string naam, string uitgever, double prijs)
        {
            Isbn = isbn;
            Naam = naam;
            Uitgever = uitgever;
            this.prijs = prijs;
        }

        public override string ToString()
        {
            return "ISBN: " + Isbn + " Naam: " + Naam + " Uitgever: " + Uitgever + " Prijs: " + Prijs + "€";
        }

        public void Lees()
        {
            Console.WriteLine("Je leest het boek " + Naam + ".");
        }

    }
}
    