using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVenerdi3
{
    class Podcast : FileMultimediali
    {
        public string Descrizione { get; set; }
        public Episodi Episodi { get; set; }


        public Podcast(string titolo, Autore autore, string descrizione, Episodi episodi)
            : base(titolo, autore)
        {
            Descrizione = descrizione;
            Episodi = episodi;
        }

        public Podcast() { }

        public override string Print()
        {
            return $"{base.Print()} |Descrizione: {Descrizione} |Episodi: {Episodi.Titolo} - {Episodi.Durata.Ore}/{Episodi.Durata.Minuti}/{Episodi.Durata.Secondi} |Sentito: {Episodi.SiAscoltato}.\n";
        }
        public override string Print2()
        {
            return $"{base.Print()} |Descrizione: {Descrizione}";
        }
    }
    }
