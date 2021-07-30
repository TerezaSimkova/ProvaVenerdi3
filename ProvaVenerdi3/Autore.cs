using System;

namespace ProvaVenerdi3
{
    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }

        public Autore(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
        }
        public Autore() { }

    }
}