using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Carte
    {
        // Attributs
        public titre _valeur;
        public type _type;
        public string _urlCarte;

        // Constructeur paramétrique
        public Carte(int valeur, int type)
        {
            _valeur = (titre)valeur;
            _type = (type)type;
            _urlCarte = getURLCarte();
        }

        // Titre
        public enum titre
        {
            As=1, Deux=2, Trois=3, Quatre=4, Cinq=5, Six=6, Sept=7, Huit=8, Neuf=9, Dix=10, Valet=11, Dame=12, Roi=13
        }
        // Valeur
        public enum type
        {
            Trèfle=1 , Pique=2, Coeur=3, Carreau=4
        }
        // Obtient la valeur numérique de la carte
        public int getValeurCarte()
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
        // Obtient l'url complet de l'image de la carte
        public string getURLCarte()
        {
            string dossier = "~/PaquetDeCartes/", typeImage = ".png";
            return dossier + (int)_valeur + getTypeUrlChunk(_type) + typeImage;
        }
        // Obtient une partie de l'url selon le type
        private string getTypeUrlChunk(type leType)
        {
            string urlchunk = null;
            switch(_type)
            {
                case type.Carreau:
                    urlchunk = "_of_diamonds";
                    break;
                case type.Coeur:
                    urlchunk = "_of_hearts";
                    break;
                case type.Pique:
                    urlchunk = "_of_spades";
                    break;
                case type.Trèfle:
                    urlchunk = "_of_clubs";
                    break;
            }
            return urlchunk;
        }
    }
}
