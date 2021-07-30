using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVenerdi3
{
    class FileMultimediali
    {
        public string Titolo { get; set; }
        public Autore Autore { get; set; }

        public FileMultimediali(string titolo, Autore autore)
        {
            Titolo = titolo;
            Autore = autore;
        }
        public FileMultimediali() { }

        public virtual string Print()
        {
            return $"*Titolo* {Titolo} |Autore: {Autore.Nome} {Autore.Cognome}| {Autore.DataDiNascita.Year}/{Autore.DataDiNascita.Month}/{Autore.DataDiNascita.Day}.";
        }
        public virtual string Print2()
        {
            return $"*Titolo* {Titolo} |Autore: {Autore.Nome} {Autore.Cognome}| {Autore.DataDiNascita.Year}/{Autore.DataDiNascita.Month}/{Autore.DataDiNascita.Day}";
        }

    }

}
