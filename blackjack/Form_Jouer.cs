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
        List<PictureBox> listCarteJ1 = new List<PictureBox>();
        public int numCarte = 0;//num de carte pigé

        // Constructeur paramétrique
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
                Application.Exit();
        }

        private void Form_Jouer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (callBackForm != null)
            //    callBackForm.Show();
            //else
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
            Point locationInitial = new Point(0, 0);
            Point tempLocation = new Point(0,0);
            int Points = 0;   
            if(listCarteJ1.Count <=0)
                tempLocation = locationInitial;
            else 
                tempLocation = listCarteJ1[numCarte].Location;
            listCarteJ1.Add(new PictureBox());
            listCarteJ1[numCarte].BackgroundImage = Image.FromFile(lePaquet.PigerCarte());
            listCarteJ1[numCarte].Location = new Point(tempLocation.X + 50, tempLocation.Y);
            listCarteJ1[numCarte].BackgroundImageLayout = ImageLayout.Stretch;
            listCarteJ1[numCarte].BackColor = Color.Red;
            listCarteJ1[numCarte].Show();
            numCarte++;

            if (LB_Points_J1.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J1.Text);
            LB_Points_J1.Text = (Points + lePaquet.GetValeur()).ToString();

        }

        private void Form_Jouer_Load(object sender, EventArgs e)
        {
        }
    }
}
