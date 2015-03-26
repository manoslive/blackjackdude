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
        public Form_Jouer()
        {
            InitializeComponent();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Jouer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Le processus ne voulait pas se terminer. J'ai du ajouter cette ligne
        }
    }
}
