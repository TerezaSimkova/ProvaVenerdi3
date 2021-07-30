using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVenerdi3
{
    class CanzoniRepositori : IdbManager<Canzoni>
    {
        
        List<Canzoni> canzoni = new List<Canzoni>()
        {
            new Canzoni("Sere Nere",new Autore("Tiziano", "Ferro", new DateTime(1980,2,21)),EnumGenere.Pop),
            new Canzoni("Imbranato",new Autore("Tiziano", "Ferro", new DateTime(1980,2,21)),EnumGenere.Pop),
            new Canzoni("Piú bella cosa",new Autore("Eros", "Ramazzoti", new DateTime(1963,10,25)),EnumGenere.Rock),
            new Canzoni("Senza Parole",new Autore("Vasco", "Rossi", new DateTime(1952,2,7)),EnumGenere.Rock),
            new Canzoni("Rollercoaster",new Autore("Emis", "Killa", new DateTime(1989,8,14)),EnumGenere.Rap),
            new Canzoni("My Way",new Autore("Frank", "Sinatra", new DateTime(1915,12,12)),EnumGenere.Jazz),
            new Canzoni("Feeling Good",new Autore("Ninna", "Simone", new DateTime(1933,4,21)),EnumGenere.Jazz),
        };

        public List<Canzoni> Fetch()
        {
            return canzoni;
        }

        internal List<Canzoni> GetByGener(EnumGenere scelta)
        {
            return canzoni.Where(c => c.Genere == scelta).ToList();
        }
    }
}
