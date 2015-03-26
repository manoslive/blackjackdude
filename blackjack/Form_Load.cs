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
    public partial class Form_Load : Form
    {
        int waitTime { get; set; }
        public Form_Load()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waitTime += 1;
            PG_Load.Increment(5);
            if(PG_Load.Value == PG_Load.Maximum && waitTime == 30)
            {
                Timer_Loading.Stop();
                this.Hide();
                Form_Choix choix = new Form_Choix();
                choix.ShowDialog();
            }
        }

        private void Form_Load_Load(object sender, EventArgs e)
        {
            PG_Load.Maximum = 100;
            PG_Load.Step = 10;
            PG_Load.Value = 0;
            Timer_Loading.Start();
        }

        private void Form_Load_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
