using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class PaquetCartes
    {
        public static Random rnd = new Random();
        public List<Carte> Paquet = new List<Carte>();

        // Lors de sa création, le paquet se voit attribué 52 cartes
        public PaquetCartes()
        {
            CreerPaquet();
            //Paquet.Add(new Carte(1, 1));
            //Paquet.Add(new Carte(1, 2));
            //Paquet.Add(new Carte(1, 3));
            //Paquet.Add(new Carte(1, 4));
            //Paquet.Add(new Carte(2, 1));
            //Paquet.Add(new Carte(2, 2));
            //Paquet.Add(new Carte(2, 3));
            //Paquet.Add(new Carte(2, 4));
            //Paquet.Add(new Carte(3, 1));
            //Paquet.Add(new Carte(3, 2));
            //Paquet.Add(new Carte(3, 3));
            //Paquet.Add(new Carte(3, 4));
            //Paquet.Add(new Carte(4, 1));
            //Paquet.Add(new Carte(4, 2));
            //Paquet.Add(new Carte(4, 3));
            //Paquet.Add(new Carte(4, 4));
            //Paquet.Add(new Carte(5, 1));
            //Paquet.Add(new Carte(5, 2));
            //Paquet.Add(new Carte(5, 3));
            //Paquet.Add(new Carte(5, 4));
            //Paquet.Add(new Carte(6, 1));
            //Paquet.Add(new Carte(6, 2));
            //Paquet.Add(new Carte(6, 3));
            //Paquet.Add(new Carte(6, 4));
            //Paquet.Add(new Carte(7, 1));
            //Paquet.Add(new Carte(7, 2));
            //Paquet.Add(new Carte(7, 3));
            //Paquet.Add(new Carte(7, 4));
            //Paquet.Add(new Carte(8, 1));
            //Paquet.Add(new Carte(8, 2));
            //Paquet.Add(new Carte(8, 3));
            //Paquet.Add(new Carte(8, 4));
            //Paquet.Add(new Carte(9, 1));
            //Paquet.Add(new Carte(9, 2));
            //Paquet.Add(new Carte(9, 3));
            //Paquet.Add(new Carte(9, 4));
            //Paquet.Add(new Carte(10, 1));
            //Paquet.Add(new Carte(10, 2));
            //Paquet.Add(new Carte(10, 3));
            //Paquet.Add(new Carte(10, 4));
            //Paquet.Add(new Carte(11, 1));
            //Paquet.Add(new Carte(11, 2));
            //Paquet.Add(new Carte(11, 3));
            //Paquet.Add(new Carte(11, 4));
            //Paquet.Add(new Carte(12, 1));
            //Paquet.Add(new Carte(12, 2));
            //Paquet.Add(new Carte(12, 3));
            //Paquet.Add(new Carte(12, 4));
            //Paquet.Add(new Carte(13, 1));
            //Paquet.Add(new Carte(13, 2));
            //Paquet.Add(new Carte(13, 3));
            //Paquet.Add(new Carte(13, 4));
        }
        private void CreerPaquet()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Paquet.Add(new Carte(j, i));
                }
            }
        }
        public string PigerCarte()
        {
            string laCarte = string.Empty;
            int rndCarte = rnd.Next(0, 52);
            //laCarte = Paquet[rndCarte].GetCarte();
            return laCarte;
        }
    }
}
