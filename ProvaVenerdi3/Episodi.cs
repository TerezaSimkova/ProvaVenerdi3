using System;

namespace ProvaVenerdi3
{
    public class Episodi
    {
        public string Titolo { get; set; }
        public Durata Durata { get; set; }
        public bool SiAscoltato { get; set; }
        //public TimeSpan timeSpan { get; set; } TODO provare con time span - perché forse il metodo stampa per durata funzionerebbe meglio ? 
        public Episodi(string titolo, Durata durata, bool siAscoltato)
        {
            Titolo = titolo;
            Durata = durata;
            SiAscoltato = siAscoltato;

        }

    }
    public struct Durata
    {
        public int Ore { get; set; }
        public int Minuti { get; set; }
        public int Secondi { get; set; }

        public Durata(int ore, int minuti, int secondi)
        {
            Ore = ore;
            Minuti = minuti;
            Secondi = secondi;
        }
    }
}