using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form_Jouer : Form
    {
        public Form callBackForm = null;
        Joueur joueur1 = null;
        Joueur joueur2 = null;
        bool nouvellePartie = false;
        PaquetCartes lePaquet = null;
        List<PictureBox> listCarteJ1 = new List<PictureBox>();
        public int numCarteJ1 = 0; //num de carte pigé
        List<PictureBox> listCarteJ2 = new List<PictureBox>();
        public int numCarteJ2 = 0; //num de carte pigé
        List<int> listCarteEnJeu = new List<int>();
        int nbAsJ1 = 0, nbAsJ2 = 0;

        ////----------------------------------------------------------
        //Fonctions forms, Reinitialiser
        ////----------------------------------------------------------
        // Constructeur paramétrique
        public Form_Jouer(bool J1estIA, Joueur.niveauIA J1niveau, bool J1estCompter,
                          bool J2estIA, Joueur.niveauIA J2niveau, bool J2estCompter)
        {
            InitializeComponent();
            lePaquet = new PaquetCartes();
            if (!J1estIA)
                joueur1 = new Joueur();
            else
            {
                joueur1 = new Joueur(J1niveau, J1estCompter);
                MettreControlesJoueurIA(joueur1);
            }

            if (!J2estIA)
                joueur2 = new Joueur();
            else
            {
                joueur2 = new Joueur(J2niveau, J2estCompter);
                MettreControlesJoueurIA(joueur2);
            }
            joueur1.SetEstSonTour(true);
            joueur2.SetEstSonTour(false);
        }
        private void Form_Jouer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nouvellePartie)
            {
                Form_Choix choix = new Form_Choix();
                choix.ShowDialog();
            }
            Application.Exit();
        }
        private void Form_Jouer_Load(object sender, EventArgs e)
        {
            if (joueur1._estIA)
            {
                MettreControlesJoueurIA(joueur1);
                IA_PigerJ1();
            }
            else
            {
                FB_PigerJ1.Visible = true;
                FB_PasserJ1.Visible = false;
                FB_PasserJ2.Visible = false;
                FB_PigerJ2.Visible = false;
            }

        }
        private void ReinitialiserRejouer(object sender, EventArgs e)
        {
            DisableButtons();
            for (int i = 0; i < listCarteJ1.Count; i++)
            {
                this.Controls.Remove(listCarteJ1[i]);
            }
            for (int i = 0; i < listCarteJ2.Count; i++)
            {
                this.Controls.Remove(listCarteJ2[i]);
            }
            joueur1._journal.Clear();
            joueur2._journal.Clear();
            listCarteJ1.Clear();
            listCarteJ2.Clear();
            listCarteEnJeu.Clear();
            BTN_Annuler.Visible = true;
            FB_PigerJ1.Visible = true;
            numCarteJ1 = 0;
            numCarteJ2 = 0;
            LB_Points_J1.Text = "0";
            LB_Points_J2.Text = "0";
            joueur1.SetEstSonTour(true);
            joueur2.SetEstSonTour(false);
            if (joueur1._estIA)
                Form_Jouer_Load(sender, e);
        }
        ////----------------------------------------------------------
        //Fonctions Boutons (BTN, FB)
        ////----------------------------------------------------------
        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BTN_AfficherJournalJ1_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form_Journal journalj1 = new Form_Journal(joueur1._journal);
            journalj1.callBackForm = this;
            journalj1.ShowDialog();
        }
        private void BTN_AfficherJournalJ2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form_Journal journalj2 = new Form_Journal(joueur1._journal);
            journalj2.callBackForm = this;
            journalj2.ShowDialog();
        }
        private void BTN_Rejouer_Click(object sender, EventArgs e)
        {
            ReinitialiserRejouer(sender, e);
        }
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            nouvellePartie = true;
            this.Hide();
            this.Close();
        }
        private void DisableButtons()
        {
            FB_PigerJ1.Visible = false;
            FB_PasserJ1.Visible = false;
            FB_PigerJ2.Visible = false;
            FB_PasserJ2.Visible = false;

            //BTN_Annuler.Visible = false;
            lePaquet = new PaquetCartes();
        }
        private void FB_PigerJ1_Click(object sender, EventArgs e)
        {
            if (numCarteJ1 == 0)
            {
                PigerCarteJ1();
                Timer_Carte.Enabled = true;
                if (!joueur1._estIA)
                    FB_PasserJ1.Visible = true;
            }
            else
                PigerCarteJ1();
        }
        private void FB_PigerJ2_Click(object sender, EventArgs e)
        {
            if (numCarteJ2 == 0)
            {
                PigerCarteJ2();
                Timer_Carte.Enabled = true;
                FB_PasserJ2.Visible = true;
            }
            else
                PigerCarteJ2();
        }
        private void FB_PasserJ1_Click(object sender, EventArgs e)
        {
            if (numCarteJ1 < 2)
                joueur1._AFini = true;

            if (!joueur2._estIA)
                ChangerTour(joueur2);
            else
            {
                ChangerTour(joueur2);
                Timer_Tour.Enabled = true;
            }
        }
        private void FB_PasserJ2_Click(object sender, EventArgs e)
        {
            joueur2._AFini = true;
            joueur2.SetEstSonTour(false);
            VerfierGagnant();
        }

        ////----------------------------------------------------------
        //Fonctions piger cartes
        ////----------------------------------------------------------
        private void IA_PigerJ1()
        {
            if (numCarteJ1 == 0)
            {
                JouerTourIA(joueur1);
                Timer_Carte.Enabled = true;
            }
            else
                JouerTourIA(joueur1);

            VerfierGagnant();
        }
        public void PigerCarteJ1()
        {
            Point locationInitial = new Point(this.Size.Width / 2 - 35, 40);
            Point tempLocation = new Point(0, 0);
            listCarteJ1.Add(new PictureBox());
            listCarteJ1[numCarteJ1].Size = new System.Drawing.Size(70, 90);
            listCarteJ1[numCarteJ1].BackgroundImage = Image.FromFile(lePaquet.PigerCarte());
            if (listCarteJ1.Count <= 1)
            {
                tempLocation = locationInitial;
                listCarteJ1[numCarteJ1].Location = new Point(tempLocation.X, tempLocation.Y);
            }
            else
            {
                tempLocation = listCarteJ1[numCarteJ1 - 1].Location;
                listCarteJ1[numCarteJ1].Location = new Point(tempLocation.X + 50, tempLocation.Y);
            }
            listCarteJ1[numCarteJ1].BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(listCarteJ1[numCarteJ1]);
            listCarteJ1[numCarteJ1].BringToFront();
            if (listCarteJ1.Count > 1)
            {
                for (int i = 0; i < listCarteJ1.Count; i++)
                {
                    listCarteJ1[i].Location = new Point(listCarteJ1[i].Location.X - 25, listCarteJ1[i].Location.Y);
                    listCarteJ1[i].BringToFront();
                }
            }
            CalculerPointsJ1();
            lePaquet.RemoveCarte();
            numCarteJ1++;
        }
        private void IA_PigerJ2()
        {
            if (numCarteJ2 == 0)
            {
                PigerCarteJ2();
                Timer_Carte.Enabled = true;
            }
            else
                PigerCarteJ2();
            VerfierGagnant();
        }
        public void PigerCarteJ2()
        {
            Point locationInitial = new Point(this.Size.Width / 2 - 35, 280);
            Point tempLocation = new Point(0, 0);
            listCarteJ2.Add(new PictureBox());
            listCarteJ2[numCarteJ2].Size = new System.Drawing.Size(70, 90);
            listCarteJ2[numCarteJ2].BackgroundImage = Image.FromFile(lePaquet.PigerCarte());
            if (listCarteJ2.Count <= 1)
            {
                tempLocation = locationInitial;
                listCarteJ2[numCarteJ2].Location = new Point(tempLocation.X, tempLocation.Y);
            }
            else
            {
                tempLocation = listCarteJ2[numCarteJ2 - 1].Location;
                listCarteJ2[numCarteJ2].Location = new Point(tempLocation.X + 50, tempLocation.Y);
            }
            listCarteJ2[numCarteJ2].BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(listCarteJ2[numCarteJ2]);
            listCarteJ2[numCarteJ2].BringToFront();
            if (listCarteJ2.Count > 1)
            {
                for (int i = 0; i < listCarteJ2.Count; i++)
                {
                    listCarteJ2[i].Location = new Point(listCarteJ2[i].Location.X - 25, listCarteJ2[i].Location.Y);
                    listCarteJ2[i].BringToFront();
                }
            }
            numCarteJ2++;
            CalculerPointsJ2();
            lePaquet.RemoveCarte();
        }

        ////----------------------------------------------------------
        //Fonctions calculer points, verifier gagnant, calculer prob
        ////----------------------------------------------------------
        private void CalculerPointsJ1()
        {
            int Points = 0;
            if (LB_Points_J1.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J1.Text);
            if (lePaquet.GetValeur() == 11)
                nbAsJ1 += 1;
            LB_Points_J1.Text = (Points + lePaquet.GetValeur()).ToString();
            if (Convert.ToInt32(LB_Points_J1.Text) > 21 && nbAsJ1 >= 1)
            {
                int pointsj1 = Convert.ToInt32(LB_Points_J1.Text) - 10;
                LB_Points_J1.Text = pointsj1.ToString();
                nbAsJ1 -= 1;
            }
            listCarteEnJeu.Add(lePaquet.GetValeur());
            VerfierGagnant();
            //ChangerTour(joueur2);
        }
        private void CalculerPointsJ2()
        {
            int Points = 0;
            if (LB_Points_J2.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J2.Text);
            if (lePaquet.GetValeur() == 11)
                nbAsJ2 += 1;
            LB_Points_J2.Text = (Points + lePaquet.GetValeur()).ToString();
            if (Convert.ToInt32(LB_Points_J2.Text) > 21 && nbAsJ2 >= 1)
            {
                int pointsj2 = Convert.ToInt32(LB_Points_J2.Text) - 10;
                LB_Points_J2.Text = pointsj2.ToString();
                nbAsJ2 -= 1;
            }
            listCarteEnJeu.Add(lePaquet.GetValeur());
            VerfierGagnant();
            //DisableButtons();
        }
        private void VerfierGagnant()
        {
            if (!joueur1.GetEstSonTour() && !joueur2.GetEstSonTour())
            {
                if (Convert.ToInt32(LB_Points_J1.Text) > Convert.ToInt32(LB_Points_J2.Text))
                    MessageBox.Show("Le Joueur 1 a gagné");
                else if (Convert.ToInt32(LB_Points_J1.Text) < Convert.ToInt32(LB_Points_J2.Text) && Convert.ToInt32(LB_Points_J2.Text) <= 21)
                    if (Convert.ToInt32(LB_Points_J2.Text) == 21)
                        MessageBox.Show("Blackjack! \nLe Joueur 2 a gagné");
                    else
                        MessageBox.Show("Le Joueur 2 a gagné");
                else if (Convert.ToInt32(LB_Points_J1.Text) == Convert.ToInt32(LB_Points_J2.Text))
                    MessageBox.Show("Partie nulle");
                DisableButtons();
            }
            else if (joueur1.GetEstSonTour() && !joueur2.GetEstSonTour())
            {
                if (Convert.ToInt32(LB_Points_J1.Text) > 21)
                {
                    MessageBox.Show("Le Joueur 1 a busté");
                    joueur1.SetEstSonTour(false);
                    joueur2.SetEstSonTour(false);
                    Timer_Tour.Enabled = false;
                    DisableButtons();
                }
            }
            else if (!joueur1.GetEstSonTour() && joueur2.GetEstSonTour())
            {
                if (Convert.ToInt32(LB_Points_J2.Text) > 21)
                {
                    MessageBox.Show("Le Joueur 2 a busté");
                    joueur1.SetEstSonTour(false);
                    joueur2.SetEstSonTour(false);
                    DisableButtons();
                }
            }
        }
        private float CalculerProb(Joueur leJoueur) // Problème ici
        {
            const int nbCarteComplet = 52;
            float probabilite = 100;
            float nbPointsAvantBusté = (21 - Convert.ToInt32(LB_Points_J1.Text));
            float compteur = nbPointsAvantBusté * 4;//4 == nombre de carte par numero
            if (nbPointsAvantBusté < 11)
            {
                for (int i = 1; i < nbPointsAvantBusté; i++)
                {
                    for (int j = 0; j < listCarteEnJeu.Count; j++)
                    {
                        if (listCarteEnJeu[j] == i)
                        {
                            compteur--; //nombre de carte pouvant etre pigé sans busté
                        }
                    }
                }
                if (leJoueur._comptage)
                    probabilite = (compteur / lePaquet.Paquet.Count) * 100; //probabilité de ne pas busté
                else
                    probabilite = (compteur / nbCarteComplet) * 100;
            }
            return probabilite;
        }

        ////----------------------------------------------------------
        //Fonctions gérer tours
        ////----------------------------------------------------------
        private void ChangerTour(Joueur aQuelJoueurEstLeTour)
        {
            if (aQuelJoueurEstLeTour == joueur1 && aQuelJoueurEstLeTour._estIA)
            {
                joueur1.SetEstSonTour(true);
                joueur2.SetEstSonTour(false);
                FB_PigerJ1.Visible = false;
                FB_PasserJ1.Visible = false;
                FB_PasserJ2.Visible = false;
                FB_PigerJ2.Visible = false;
            }
            else if (aQuelJoueurEstLeTour == joueur2 && aQuelJoueurEstLeTour._estIA)
            {
                joueur1.SetEstSonTour(false);
                joueur2.SetEstSonTour(true);
                FB_PigerJ1.Visible = false;
                FB_PasserJ1.Visible = false;
                FB_PasserJ2.Visible = false;
                FB_PigerJ2.Visible = false;
            }
            else if (aQuelJoueurEstLeTour == joueur1)
            {
                joueur1.SetEstSonTour(true);
                joueur2.SetEstSonTour(false);
                FB_PigerJ1.Visible = true;
                FB_PasserJ1.Visible = true;
                FB_PasserJ2.Visible = false;
                FB_PigerJ2.Visible = false;
            }
            else if (aQuelJoueurEstLeTour == joueur2)
            {
                joueur2.SetEstSonTour(true);
                joueur1.SetEstSonTour(false);
                FB_PigerJ1.Visible = false;
                FB_PasserJ1.Visible = false;
                FB_PasserJ2.Visible = true;
                FB_PigerJ2.Visible = true;
            }

        }
        private void MettreControlesJoueurIA(Joueur joueur)
        {
            if (joueur == joueur1)
            {
                FB_PigerJ1.Visible = false;
                FB_PasserJ1.Visible = false;
            }
            else if (joueur == joueur2)
            {
                FB_PigerJ2.Visible = false;
                FB_PasserJ2.Visible = false;
            }
        }
        private void JouerTourIA(Joueur leIA)
        {
            if (leIA == joueur1)
                if (Convert.ToInt32(LB_Points_J1.Text) <= 10)
                {
                    joueur1.AjouterAuJournal("Le joueur#1 avait un total plus petit ou égale à 10. Il a pigé une carte.");
                    PigerCarteJ1();
                }
                else if (CalculerProb(joueur1) >= Convert.ToInt32(leIA._niveauIA))
                {
                    joueur1.AjouterAuJournal("Le joueur#1 avait " + CalculerProb(joueur1) + "% de chance de ne pas dépasser 21. Il a pigé une carte");
                    PigerCarteJ1();
                }
                else
                    if (!joueur2._estIA)
                    {
                        Timer_Tour.Enabled = false;
                        joueur1.AjouterAuJournal("Le joueur#1 avait " + CalculerProb(joueur1) + "% de chance de ne pas dépasser 21. Son niveau était de " + Convert.ToInt32(leIA._niveauIA).ToString() + ". Il a donc passé son tour.");
                        ChangerTour(joueur2);
                        //joueur2.AjouterAuJournal("Le joueur#2 avait " + CalculerProb(joueur2) + "% de chance de ne pas dépasser 21. Son niveau était de " + Convert.ToInt32(leIA._niveauIA).ToString() + ". Il a donc passé son tour.");
                    }
                    else
                        ChangerTour(joueur2);
            else if (leIA == joueur2)
            {
                if (Convert.ToInt32(LB_Points_J2.Text) > 21)
                {
                    Timer_Tour.Enabled = false;
                    //VerfierGagnant();
                }
                else if (Convert.ToInt32(LB_Points_J1.Text) >= Convert.ToInt32(LB_Points_J2.Text))
                {
                    joueur2.AjouterAuJournal("Le joueur#2 avait " + CalculerProb(joueur2) + "% de chance de ne pas dépasser 21. Son niveau était de " + Convert.ToInt32(leIA._niveauIA).ToString() + ". Il a donc passé son tour.");
                    IA_PigerJ2();
                }
                else if (Convert.ToInt32(LB_Points_J2.Text) > 21)
                {
                    Timer_Tour.Enabled = false;
                    joueur1.SetEstSonTour(false);
                    joueur2.SetEstSonTour(false);
                    VerfierGagnant();
                }
                else
                {
                    Timer_Tour.Enabled = false;
                    joueur1.SetEstSonTour(false);
                    joueur2.SetEstSonTour(false);
                    VerfierGagnant();
                }
            }
        }

        ////----------------------------------------------------------
        //Fonctions timers
        ////----------------------------------------------------------
        private void Timer_Tour_Tick(object sender, EventArgs e)
        {
            if (joueur1.GetEstSonTour())
                JouerTourIA(joueur1);
            else
                JouerTourIA(joueur2);
        }

        private void Timer_Carte_Tick(object sender, EventArgs e)
        {
            Timer_Carte.Enabled = false;
            if (joueur1.GetEstSonTour())
                if (!joueur1._estIA)
                    PigerCarteJ1();
                else
                    Timer_Tour.Enabled = true;
            else
                PigerCarteJ2();
        }
    }
}
