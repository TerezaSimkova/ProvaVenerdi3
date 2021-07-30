using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVenerdi3
{
    class PodcastRepositori : IdbManager<Podcast>
    {

        List<Podcast> podcast = new List<Podcast>()
        {
            new Podcast("Musica_Mondiale", new Autore("Kevin","Blake", new DateTime(1995,12,3)),"Podcast sulla musica italiana.",new Episodi("Musica Italiana 01", new Durata(2,30,15),false)),
            new Podcast("Musica_Mondiale", new Autore("Kevin","Blake", new DateTime(1995,12,3)),"Podcast sulla musica italiana.",new Episodi("Musica Italiana 02", new Durata(3,01,08),false)),
            new Podcast("Cucina_Francese", new Autore("Alice","Shaw", new DateTime(1999,10,8)),"Podcast sulla cucina francese.",new Episodi("Verdure 01", new Durata(1,18,15),false)),
            new Podcast("Cucina_Francese", new Autore("Alice","Shaw", new DateTime(1999,10,8)),"Podcast sulla cucina francese.",new Episodi("Carne 02", new Durata(1,45,11),false)),
            new Podcast("Viaggiare", new Autore("Bobby","Gold", new DateTime(2000,3,3)),"Podcast sui viaggi.",new Episodi("Preparazione viaggio 01", new Durata(1,30,00),false)),
            new Podcast("Viaggiare", new Autore("Bobby","Gold", new DateTime(2000,3,3)),"Podcast sui viaggi.",new Episodi("Assicurazione viaggio 02", new Durata(1,05,00),false)),
        };

        

        public List<Podcast> Fetch()
        {
            return podcast;
        }

        internal List<Podcast> MostryByDurata(Durata d)
        {
            var d1 = podcast.Where(p => p.Episodi.Durata.Ore <= d.Ore).ToList(); //TODO stampare anche secondo i minuti e secondi ,adesso controlla solo ora
            var d2 = d1.Where(p => p.Episodi.Durata.Minuti <= d.Minuti).ToList();
            var d3 = d1.Where(p => p.Episodi.Durata.Minuti <= d.Secondi).ToList();

            return d1;
        }

        internal List<Podcast> FetchByPodcast(string scelta)
        {
            return podcast.Where(p => p.Titolo == scelta).ToList();
        }
    }
}
