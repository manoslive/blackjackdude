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
        public int numCarteJ1 = 0;//num de carte pigé
        List<PictureBox> listCarteJ2 = new List<PictureBox>();
        public int numCarteJ2 = 0;//num de carte pigé
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


        }

        private void Form_Jouer_Load(object sender, EventArgs e)
        {
        }

        private void LB_Points_J1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckWin()
        {
            int ptsJ1 = Convert.ToInt32(LB_Points_J1.Text);
            while(!joueur1._AFini)
            {

            }
        }

        private void FB_PigerJ1_Click(object sender, EventArgs e)
        {
            int Points = 0;
            PigerCarteJ1();
            if (LB_Points_J1.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J1.Text);
            LB_Points_J1.Text = (Points + lePaquet.GetValeur()).ToString();
        }
        public void PigerCarteJ1()
        {
            Point locationInitial = new Point(this.Size.Width / 2 - 35, 40);
            Point tempLocation = new Point(0, 0);
            if (listCarteJ1.Count <= 0)
                tempLocation = locationInitial;
            else
                tempLocation = listCarteJ1[numCarteJ1 - 1].Location;
            listCarteJ1.Add(new PictureBox());
            listCarteJ1[numCarteJ1].Size = new System.Drawing.Size(70, 90);
            listCarteJ1[numCarteJ1].BackgroundImage = Image.FromFile(lePaquet.PigerCarte());
            listCarteJ1[numCarteJ1].Location = new Point(tempLocation.X + 50, tempLocation.Y);
            listCarteJ1[numCarteJ1].BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(listCarteJ1[numCarteJ1]);
            listCarteJ1[numCarteJ1].BringToFront();
            for (int i = 0; i < listCarteJ1.Count; i++)
            {
                listCarteJ1[i].Location = new Point(tempLocation.X - 35, tempLocation.Y);
                this.Controls.Add(listCarteJ1[i]);
            }
            numCarteJ1++;
        }

        private void FB_PigerJ2_Click(object sender, EventArgs e)
        {
            int Points = 0;
            PigerCarteJ2();
            if (LB_Points_J2.Text.Length > 0)
                Points = Convert.ToInt32(LB_Points_J2.Text);
            LB_Points_J2.Text = (Points + lePaquet.GetValeur()).ToString();
        }

        public void PigerCarteJ2()
        {
            Point locationInitial = new Point(this.Size.Width / 2 - 35, 280);
            Point tempLocation = new Point(0, 0);
            if (listCarteJ2.Count <= 0)
                tempLocation = locationInitial;
            else
                tempLocation = listCarteJ2[numCarteJ2 - 1].Location;
            listCarteJ2.Add(new PictureBox());
            listCarteJ2[numCarteJ2].Size = new System.Drawing.Size(70, 90);
            listCarteJ2[numCarteJ2].BackgroundImage = Image.FromFile(lePaquet.PigerCarte());
            listCarteJ2[numCarteJ2].Location = new Point(tempLocation.X + 50, tempLocation.Y);
            listCarteJ2[numCarteJ2].BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(listCarteJ2[numCarteJ2]);
            listCarteJ2[numCarteJ2].BringToFront();
            for (int i = 0; i < listCarteJ2.Count; i++)
            {
                listCarteJ2[i].Location = new Point(tempLocation.X - 35, tempLocation.Y);
                this.Controls.Add(listCarteJ2[i]);
            }
            numCarteJ2++;
        }
    }
}
