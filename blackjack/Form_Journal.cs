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
    public partial class Form_Journal : Form
    {
        public Form callBackForm = null;
        private const int OFFSET = 23;
        public Form_Journal(List<string> entrees)
        {
            InitializeComponent();

            int compteur = 0;

            foreach (String s in entrees)
            {
                compteur++;
                Label numero = new Label();
                numero.AutoSize = true;
                numero.Text = compteur.ToString();
                numero.Location = new Point(OFFSET, OFFSET * compteur);
                this.Controls.Add(numero);

                Label lesEntrees = new Label();
                lesEntrees.AutoSize = true;
                lesEntrees.Text = s;
                lesEntrees.Location = new Point(OFFSET + OFFSET, OFFSET * compteur);
                this.Controls.Add(lesEntrees);
            }
        }

        private void Form_Journal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            else
                Application.Exit();
        }
    }
}
