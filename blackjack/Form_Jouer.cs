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
        }


        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BTN_AfficherJournalJ1_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form_Journal journalj1 = new Form_Journal(joueur1._journal);
            journalj1.callBackForm = this;
            journalj1.ShowDialog();
        }

        private void Form_Jouer_Load(object sender, EventArgs e)
        {
            if (joueur1._estIA)
            {
                MettreControlesJoueurIA(joueur1);
                JouerTourIA(joueur1);
            }
            else
            {
                FB_PigerJ1.Visible = true;
                FB_PasserJ1.Visible = false;
                FB_PasserJ2.Visible = false;
                FB_PigerJ2.Visible = false;
            }

        }
        private void ChangerTour(Joueur aQuelJoueurEstLeTour)
        {
            if (aQuelJoueurEstLeTour == joueur1)
            {
                FB_PigerJ1.Visible = true;
                FB_PasserJ1.Visible = true;
                FB_PasserJ2.Visible = false;
                FB_PigerJ2.Visible = false;
            }
            else if (aQuelJoueurEstLeTour == joueur2)
            {
                FB_PigerJ1.Visible = false;
                FB_PasserJ1.Visible = false;
                FB_PasserJ2.Visible = true;
                FB_PigerJ2.Visible = true;
            }

        }
        private void LB_Points_J1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FB_PigerJ1_Click(object sender, EventArgs e)
        {
            if (numCarteJ1 == 0)
            {
                PigerCarteJ1();
                PigerCarteJ1();
                FB_PasserJ1.Visible = true;
            }
            else
                PigerCarteJ1();

            // ChangerTour(joueur2);
        }
        private void CalculerPointsJ1()
        {
            int Points = 0;
            if (LB_Points_J1.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J1.Text);
            LB_Points_J1.Text = (Points + lePaquet.GetValeur()).ToString();
            listCarteEnJeu.Add(lePaquet.GetValeur());
            if (Convert.ToInt32(LB_Points_J1.Text) == 21)
            {
                MessageBox.Show("BlackJack!");
            }
            else if (Convert.ToInt32(LB_Points_J1.Text) > 21)
            {
                MessageBox.Show("Vous avez busté! \nJoueur 2 à gagné");
                DisableButtons();
            }
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

        private void FB_PigerJ2_Click(object sender, EventArgs e)
        {
            if (numCarteJ2 == 0)
            {
                PigerCarteJ2();
                PigerCarteJ2();
                FB_PasserJ2.Visible = true;
            }
            else
                PigerCarteJ2();
        }
        private void CalculerPointsJ2()
        {
            int Points = 0;
            if (LB_Points_J2.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J2.Text);
            LB_Points_J2.Text = (Points + lePaquet.GetValeur()).ToString();
            listCarteEnJeu.Add(lePaquet.GetValeur());
            if (Convert.ToInt32(LB_Points_J2.Text) == 21)
            {
                MessageBox.Show("BlackJack!");
            }
            else if (Convert.ToInt32(LB_Points_J2.Text) > 21)
            {
                MessageBox.Show("Vous avez busté! \nJoueur 1 à gagné");
                DisableButtons();
            }
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

        private void FB_PasserJ1_Click(object sender, EventArgs e)
        {
            if (numCarteJ1 < 2)
                joueur1._AFini = true;

            if (!joueur2._estIA)
                ChangerTour(joueur2);
            else
                JouerTourIA(joueur2);
        }

        private void FB_PasserJ2_Click(object sender, EventArgs e)
        {
            joueur2._AFini = true;
            VerfierGagnant();
        }
        private void VerfierGagnant()
        {
            if (Convert.ToInt32(LB_Points_J1.Text) > Convert.ToInt32(LB_Points_J2.Text))
                MessageBox.Show("Le Joueur1 a gagné");
            else if (Convert.ToInt32(LB_Points_J1.Text) < Convert.ToInt32(LB_Points_J2.Text))
                MessageBox.Show("Le Joueur2 a gagné");
            else
                MessageBox.Show("Partie nulle");
            DisableButtons();
        }

        private void BTN_AfficherJournalJ2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form_Journal journalj2 = new Form_Journal(joueur1._journal);
            journalj2.callBackForm = this;
            journalj2.ShowDialog();
        }
        private void DisableButtons()
        {
            //foreach (FlashButton.FlashButton x in this.Controls)
            //{
            //    ((FlashButton.FlashButton)x).Visible = false;
            //}
            FB_PigerJ1.Visible = false;
            FB_PasserJ1.Visible = false;
            FB_PigerJ2.Visible = false;
            FB_PasserJ2.Visible = false;

            BTN_Annuler.Visible = false;
            lePaquet = new PaquetCartes();
        }
        private void BTN_Rejouer_Click(object sender, EventArgs e)
        {
            ReinitialiserRejouer();
        }
        private void ReinitialiserRejouer()
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
            listCarteJ1.Clear();
            listCarteJ2.Clear();
            listCarteEnJeu.Clear();
            FB_PigerJ1.Visible = true;
            BTN_Annuler.Visible = true;
            numCarteJ1 = 0;
            numCarteJ2 = 0;
            LB_Points_J1.Text = "";
            LB_Points_J2.Text = "";
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            nouvellePartie = true;
            this.Hide();
            this.Close();
        }
        private int CalculerProb(Joueur leJoueur) // Problème ici
        {
            int compteur = 21 - Convert.ToInt32(LB_Points_J1.Text);
            for (int i = 1; i <= 21 - Convert.ToInt32(LB_Points_J1.Text); i++)
            {
                for (int j = 0; j < listCarteEnJeu.Count; i++)
                {
                    if (listCarteEnJeu[j] == i)
                    {
                        compteur--;
                    }
                }
            }
            int nombreCarteRestante = 52 - listCarteEnJeu.Count;
            int probabilite = (compteur / nombreCarteRestante) * 100;
            leJoueur.AjouterAuJournal("Le joueur avait " + probabilite + "% de chance de ne pas dépasser 21");
            return probabilite;
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
                if (CalculerProb(joueur1) >= Convert.ToDouble(leIA._niveauIA))
                    PigerCarteJ1();
                else
                    if (!joueur2._estIA)
                        ChangerTour(joueur2);
                    else
                        JouerTourIA(joueur2);
            else if (leIA == joueur2)
                if (CalculerProb(joueur2) >= Convert.ToDouble(leIA._niveauIA))
                    PigerCarteJ2();
                else
                    VerfierGagnant();
        }
    }
}
