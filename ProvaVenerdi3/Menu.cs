using System;
using System.Collections.Generic;

namespace ProvaVenerdi3
{
    internal class Menu
    {
        static CanzoniRepositori can = new CanzoniRepositori();
        static PodcastRepositori pod = new PodcastRepositori();
        internal static void Start()
        {
            Console.WriteLine("***Benvenuto***\n");

            Console.WriteLine("Premi 1 per visualizzare tutte le canzoni");
            Console.WriteLine("Premi 2 per visualizzare tutti i podcast");
            Console.WriteLine("Premi 3 per visualizzare canzoni di un certo genere.");
            Console.WriteLine("Premi 4 per visualizzare i episodi di un certo podcast.");
            Console.WriteLine("Premi 5 per visualizzare podcast con la durata <= a quello scritto dal utente.\n");

            int scelta;
            bool continua = true;

            while (continua)
            {

                do
                {
                    Console.WriteLine("Cosa scegli di fare?\n");

                } while (!int.TryParse(Console.ReadLine(), out scelta));
                if (scelta < 0 || scelta > 5)
                {
                    Console.WriteLine("Scelta Sbagliata!");
                }
                else
                {
                    switch (scelta)
                    {
                        case 1:
                            StampaTutteCanzoni();
                            break;
                        case 2:
                            StampaTuttiPodcast();
                            break;
                        case 3:
                            FiltraCanzoni();
                            break;
                        case 4:
                            FiltraEpisodi();
                            break;
                        case 5:
                            MostraByDurata();
                            break;
                        default:
                            Console.WriteLine("Scelta non valida!");
                            break;
                    }
                }

            }
        }

        private static void MostraByDurata()
        {
            Console.WriteLine("Inserisci la durata del episodio in questo ordine: Ore / Minuti / Secondi.");
            Durata d = new Durata();
            while (true)
            {
                int ore;
                do
                {
                    Console.WriteLine("Inserisci le ore.");

                } while (!int.TryParse(Console.ReadLine(), out ore));
                d.Ore = ore;

                int minuti;
                do
                {
                    Console.WriteLine("Inserisci i minuti.");

                } while (!int.TryParse(Console.ReadLine(), out minuti));
                d.Minuti = minuti;

                int secondi;
                do
                {
                    Console.WriteLine("Inserisci i secondi.");

                } while (!int.TryParse(Console.ReadLine(), out secondi));
                d.Secondi = secondi;

                List<Podcast> podcast = pod.Fetch();
                podcast = pod.MostryByDurata(d);
                foreach (var p in podcast)
                {
                    Console.WriteLine(p.Print());
                }
            }
            


        }

        private static void FiltraEpisodi()  // TODO controllo del inserimento , visualizzare solo episodi ????
        {
            string scelta;
            Console.WriteLine("Inserisci un podcast di questi: Musica_Mondiale / Cucina_Francese / Viaggiare per vedere i suoi episodi.\n");

            scelta = Console.ReadLine();
            if (String.IsNullOrEmpty(scelta))
            {
                Console.WriteLine("Scelta sbagliata!"); // non la vedo nella consolle, se metto (!String..) la vedo ma blocca tutto 
            }
            else
            {
                List<Podcast> podcast = pod.Fetch();
                podcast = pod.FetchByPodcast(scelta);
                foreach (var E in podcast)
                {
                    Console.WriteLine(E.Print());
                }
            }
            
        }

        private static void FiltraCanzoni()
        {
            EnumGenere scelta;
                      
            do
            {
                Console.WriteLine("Inserisci genere per vedere le canzoni di questo genere: Pop - Rock - Jazz - Rap :");

            } while (!EnumGenere.TryParse(Console.ReadLine(), out scelta));
            if (scelta == EnumGenere.Pop || scelta == EnumGenere.Rock || scelta == EnumGenere.Jazz || scelta == EnumGenere.Rap)
            {
                List<Canzoni> canzoni = can.Fetch();
                canzoni = can.GetByGener(scelta);
                foreach (var g in canzoni)
                {
                    Console.WriteLine(g.Print());
                }

            }
            else
            {
                Console.WriteLine("Scelta non valida");
            }



        }

        private static void StampaTuttiPodcast()
        {
            List<Podcast> podcast = pod.Fetch();

            foreach (var podc in podcast)
            {
                Console.WriteLine(podc.Print2());
            }
        }

        private static void StampaTutteCanzoni()
        {

            List<Canzoni> canzoni = can.Fetch();
           
            foreach (var canz in canzoni)
            {
                Console.WriteLine(canz.Print());
            }
        }
    }
}