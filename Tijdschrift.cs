using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boekWinkel
{
    public enum Verschijningsperiode
    {
        Dagelijks,
        Wekelijks,
        Maandelijks
    }

    class Tijdschrift : Boek
    {
        public Verschijningsperiode Periode { get; set; }

        public Tijdschrift(string isbn, string naam, string uitgever, double prijs, Verschijningsperiode periode) 
            : base(isbn, naam, uitgever, prijs)
        {
            Periode = periode;
        }

        public override string ToString()
        {
            return "Verschijningsperiode: " + Periode;
        }

    }
}
