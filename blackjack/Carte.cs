using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Carte
    {
        // Attributs
        public titre _valeur;
        public type _type;

        // Constructeur paramétrique
        public Carte(int valeur, int type)
        {
            _valeur = (titre)valeur;
            _type = (type)type;
        }

        // Titre
        public enum titre
        {
            As=1, Deux=2, Trois=3, Quatre=4, Cinq=5, Six=6, Sept=7, Huit=8, Neuf=9, Dix=10, Valet=11, Dame=12, Roi=13
        }
        // Valeur
        public enum type
        {
            Trèfle, Pique, Coeur, Carreau
        }
        // Obtient la valeur numérique de la carte
        private int getValeurCarte()
        {
            const int FIGURES = 10;
            const int AS = 11; // Il faudrait voir comment choisir entre 1 et 11 ////////////////////////////////
            int resultat;

            if (_valeur == titre.Valet || _valeur == titre.Dame || _valeur == titre.Roi)
                resultat = FIGURES;
            else if (_valeur == titre.As)
                resultat = AS;
            else
                resultat = (int)_valeur;

            return resultat;
        }
    }
}
