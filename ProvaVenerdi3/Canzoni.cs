using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVenerdi3
{
    class Canzoni : FileMultimediali
    {
        public EnumGenere Genere { get; set; }

        public Canzoni(string titolo, Autore autore, EnumGenere genere)
            : base(titolo, autore)
        {
            Genere = genere;
        }
        public Canzoni() { }

        public override string Print()
        {
            return $"{base.Print()} |Genere: {Genere}.\n";
        }
    }


    public enum EnumGenere
    {
        Pop,
        Rock,
        Rap,
        Jazz
    }

}
