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
    public partial class Form_Choix : Form
    {
        public bool joueur1_EstCompter {get; set;}
        public bool joueur2_EstCompter { get; set; }


        public Form_Choix()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EnableIAJ1();
        }

        private void RB_J2_IA_CheckedChanged(object sender, EventArgs e)
        {
            EnableIAJ2();
        }

        public void EnableIAJ2()
        {
            RB_J2_Courageux.Enabled = true;
            RB_J2_Moyen.Enabled = true;
            RB_J2_Prudent.Enabled = true;
            CB_J2_Comptage.Enabled = true;
        }
        public void DisableIAJ2()
        {
            RB_J2_Courageux.Enabled = false;
            RB_J2_Moyen.Enabled = false;
            RB_J2_Prudent.Enabled = false;
            CB_J2_Comptage.Enabled = false;
        }
        public void EnableIAJ1()
        {
            RB_J1_Courageux.Enabled = true;
            RB_J1_Moyen.Enabled = true;
            RB_J1_Prudent.Enabled = true;
            CB_J1_Comptage.Enabled = true;
        }
        public void DisableIAJ1()
        {
            RB_J1_Courageux.Enabled = false;
            RB_J1_Moyen.Enabled = false;
            RB_J1_Prudent.Enabled = false;
            CB_J1_Comptage.Enabled = false;
        }

        private void RB_J2_Humain_CheckedChanged(object sender, EventArgs e)
        {
            DisableIAJ2();
        }

        private void RB_J1_Humain_CheckedChanged(object sender, EventArgs e)
        {
            DisableIAJ1();
        }

        private void BTN_Jouer_Click(object sender, EventArgs e)
        {
            
        }

        private void CB_J1_Comptage_CheckedChanged(object sender, EventArgs e)
        {
            if (joueur1_EstCompter)
                joueur1_EstCompter = false;
            else
                joueur1_EstCompter = true;
        }

        private void CB_J2_Comptage_CheckedChanged(object sender, EventArgs e)
        {
            if (joueur2_EstCompter)
                joueur2_EstCompter = false;
            else
                joueur2_EstCompter = true;
        }
    }
}
