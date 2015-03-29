using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{

    public class Joueur
    {
        // Attributs
        public enum niveauIA { Prudent = 80, Moyen = 50, Courageux = 30, Aucun = 0 };
        public bool _comptage { get; set; }
        public bool _estIA { get; set; }
        public niveauIA _niveauIA;
        public int _nbPoints { get; set; }
        public bool _AFini { get; set; }
        public List<String> _journal { get; set; }
        public bool _estSonTour { get; set; }

        // Constructeur sans paramètre
        public Joueur()
        {
            _comptage = false;
            _estIA = false;
            _AFini = false;
            _journal = new List<string>();
            _nbPoints = 0;
        }
        // Constructeur avec paramètres
        public Joueur(niveauIA niveau, bool comptage)
        {
            _estIA = true;
            _niveauIA = niveau;
            _comptage = comptage;
            _journal = new List<string>();
            _nbPoints = 0;
        }
        // Vérifie selon le niveau de l'IA s'il peut piger une carte
        public bool PigeCarte(double possibiliteDeNePasBuster)
        {
            if (possibiliteDeNePasBuster >= ((double)_niveauIA) / 100.0)
                return true;
            else
                return false;
        }
        public void AjouterAuJournal(string message)
        {
            _journal.Add(message);
        }
        public void AjouterAuJournalConcatenate(int nbBonnesCartes, double possibiliteDeNePasBuster)
        {
            string message = "Mon pointage est de ";
            _journal.Add(message);
        }
        public bool GetEstSonTour()
        {
            return _estSonTour;
        }
        public void SetEstSonTour(bool sonTour)
        {
             _estSonTour = sonTour;
        }

    }
}
