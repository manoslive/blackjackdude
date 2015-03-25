using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{

    class Joueur
    {
        // Attributs
        public enum niveauIA { Prudent = 80, Moyen = 65, Courageux = 50, Aucun = 0 };
        public bool _comptage { get; set; }
        public bool _estIA { get; set; }
        public niveauIA _niveauIA;
        public int _nbPoints { get; set; }
        public bool _AFini { get; set; }
        public List<String> _journal { get; set; }

        public Joueur()
        {
            _comptage = false;
            _estIA = false;
            _AFini = false;
            _journal = new List<string>();
        }
        public Joueur(niveauIA niveau, bool comptage)
        {
            _estIA = true;
            _niveauIA = niveau;
            _comptage = comptage;
        }
        public bool PigeCarte(double possibiliteDeNePasBuster)
        {
            if (possibiliteDeNePasBuster >= ((double)_niveauIA) / 100.0)
                return true;
            else
                return false;
        }
        public void AjouterAuJournal(int nbBonnesCartes, double possibiliteDeNePasBuster)
        {
            string message = "Mon pointage est de ";
            _journal.Add(message);
        }

    }
}
