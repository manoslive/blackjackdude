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
        PaquetCartes lePaquet = new PaquetCartes();

        // Constructeurs paramétrique (2 joueurs IA)
        public Form_Jouer(bool J1estIA, Joueur.niveauIA J1niveau, bool J1estCompter,
                          bool J2estIA, Joueur.niveauIA J2niveau, bool J2estCompter)
        {
            InitializeComponent();
            if (!J1estIA)
                joueur1 = new Joueur();
            else
                joueur1 = new Joueur(J1niveau, J1estCompter);

            if (!J2estIA)
                joueur2 = new Joueur();
            else
                joueur2 = new Joueur(J2niveau, J2estCompter);
        }


        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            else
                Application.Exit(); // Le processus ne voulait pas se terminer. J'ai du ajouter cette ligne
        }

        private void Form_Jouer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            else
                Application.Exit(); // Le processus ne voulait pas se terminer. J'ai du ajouter cette ligne
        }

        private void BTN_AfficherJournalJ1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Journal journalj1 = new Form_Journal(joueur1._journal);
            journalj1.callBackForm = this;
            journalj1.ShowDialog();
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            PB_J1_Carte1.BackgroundImage = Image.FromFile(lePaquet.PigerCarte());
            PB_J1_Carte1.BackgroundImageLayout = ImageLayout.Stretch;
            LB_Points_J1.Text = lePaquet.GetValeur().ToString();

        }

        private void Form_Jouer_Load(object sender, EventArgs e)
        {
        }
    }
}
