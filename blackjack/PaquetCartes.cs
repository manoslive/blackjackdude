﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class PaquetCartes
    {
        private static Random rnd = new Random();
        private List<Carte> Paquet = new List<Carte>();
        private int cartePigé; //contient le numéro de la dernière carte pigé de la liste Paquet

        // Lors de sa création, le paquet se voit attribué 
        // 52 cartes différentes (sans les jokers)
        public PaquetCartes()
        {
            CreerPaquet();
        }
        private void CreerPaquet()
        {
            const int NBTYPECARTES = 4;
            const int NBCARTESPARTYPE = 13;

            for (int i = 0; i < NBTYPECARTES; i++)
            {
                for (int j = 0; j < NBCARTESPARTYPE; j++)
                {
                    Paquet.Add(new Carte(j, i));
                }
            }
        }
        public string PigerCarte()
        {
            cartePigé = rnd.Next(0, 52);
            string laCarte = Paquet[cartePigé].getURLCarte();
            return laCarte;
        }
        public int GetValeur()
        {
            return Paquet[cartePigé].getValeurCarte();
        }
    }
}
