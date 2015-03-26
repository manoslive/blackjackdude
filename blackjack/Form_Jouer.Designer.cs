namespace blackjack
{
    partial class Form_Jouer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Joueur1 = new System.Windows.Forms.Label();
            this.LB_Joueur2 = new System.Windows.Forms.Label();
            this.LB_PointageJ1 = new System.Windows.Forms.Label();
            this.GB_OptionJoueur2 = new System.Windows.Forms.GroupBox();
            this.FB_PasserJ2 = new FlashButton.FlashButton();
            this.FB_PigerJ2 = new FlashButton.FlashButton();
            this.GB_OptionJoueur1 = new System.Windows.Forms.GroupBox();
            this.FB_PasserJ1 = new FlashButton.FlashButton();
            this.FB_PigerJ1 = new FlashButton.FlashButton();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.BTN_Rejouer = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_AfficherJournalJ1 = new System.Windows.Forms.Button();
            this.BTN_AfficherJournalJ2 = new System.Windows.Forms.Button();
            this.LB_Points_J1 = new System.Windows.Forms.Label();
            this.LB_PointageJ2 = new System.Windows.Forms.Label();
            this.LB_Points_J2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_OptionJoueur2.SuspendLayout();
            this.GB_OptionJoueur1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Joueur1
            // 
            this.LB_Joueur1.AutoSize = true;
            this.LB_Joueur1.Location = new System.Drawing.Point(35, 23);
            this.LB_Joueur1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Joueur1.Name = "LB_Joueur1";
            this.LB_Joueur1.Size = new System.Drawing.Size(45, 13);
            this.LB_Joueur1.TabIndex = 0;
            this.LB_Joueur1.Text = "Joueur1";
            // 
            // LB_Joueur2
            // 
            this.LB_Joueur2.AutoSize = true;
            this.LB_Joueur2.Location = new System.Drawing.Point(35, 265);
            this.LB_Joueur2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Joueur2.Name = "LB_Joueur2";
            this.LB_Joueur2.Size = new System.Drawing.Size(45, 13);
            this.LB_Joueur2.TabIndex = 0;
            this.LB_Joueur2.Text = "Joueur2";
            // 
            // LB_PointageJ1
            // 
            this.LB_PointageJ1.AutoSize = true;
            this.LB_PointageJ1.Location = new System.Drawing.Point(35, 135);
            this.LB_PointageJ1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_PointageJ1.Name = "LB_PointageJ1";
            this.LB_PointageJ1.Size = new System.Drawing.Size(98, 13);
            this.LB_PointageJ1.TabIndex = 3;
            this.LB_PointageJ1.Text = "Valeur des cartes : ";
            // 
            // GB_OptionJoueur2
            // 
            this.GB_OptionJoueur2.Controls.Add(this.FB_PasserJ2);
            this.GB_OptionJoueur2.Controls.Add(this.FB_PigerJ2);
            this.GB_OptionJoueur2.Location = new System.Drawing.Point(340, 159);
            this.GB_OptionJoueur2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_OptionJoueur2.Name = "GB_OptionJoueur2";
            this.GB_OptionJoueur2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_OptionJoueur2.Size = new System.Drawing.Size(188, 92);
            this.GB_OptionJoueur2.TabIndex = 4;
            this.GB_OptionJoueur2.TabStop = false;
            this.GB_OptionJoueur2.Text = "Option J2";
            // 
            // FB_PasserJ2
            // 
            this.FB_PasserJ2.BackgroundImage = global::blackjack.Properties.Resources.check_default;
            this.FB_PasserJ2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_PasserJ2.ImageClick = global::blackjack.Properties.Resources.check_click;
            this.FB_PasserJ2.ImageDisable = null;
            this.FB_PasserJ2.ImageNeutral = global::blackjack.Properties.Resources.check_default;
            this.FB_PasserJ2.ImageOver = null;
            this.FB_PasserJ2.Location = new System.Drawing.Point(100, 18);
            this.FB_PasserJ2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_PasserJ2.Name = "FB_PasserJ2";
            this.FB_PasserJ2.Size = new System.Drawing.Size(73, 67);
            this.FB_PasserJ2.TabIndex = 0;
            this.FB_PasserJ2.Click += new System.EventHandler(this.FB_PasserJ2_Click);
            // 
            // FB_PigerJ2
            // 
            this.FB_PigerJ2.BackgroundImage = global::blackjack.Properties.Resources.piger_click;
            this.FB_PigerJ2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_PigerJ2.ImageClick = global::blackjack.Properties.Resources.piger_default;
            this.FB_PigerJ2.ImageDisable = null;
            this.FB_PigerJ2.ImageNeutral = global::blackjack.Properties.Resources.piger_click;
            this.FB_PigerJ2.ImageOver = null;
            this.FB_PigerJ2.Location = new System.Drawing.Point(13, 18);
            this.FB_PigerJ2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_PigerJ2.Name = "FB_PigerJ2";
            this.FB_PigerJ2.Size = new System.Drawing.Size(73, 67);
            this.FB_PigerJ2.TabIndex = 0;
            this.FB_PigerJ2.Click += new System.EventHandler(this.FB_PigerJ2_Click);
            // 
            // GB_OptionJoueur1
            // 
            this.GB_OptionJoueur1.Controls.Add(this.FB_PasserJ1);
            this.GB_OptionJoueur1.Controls.Add(this.FB_PigerJ1);
            this.GB_OptionJoueur1.Location = new System.Drawing.Point(46, 159);
            this.GB_OptionJoueur1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_OptionJoueur1.Name = "GB_OptionJoueur1";
            this.GB_OptionJoueur1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_OptionJoueur1.Size = new System.Drawing.Size(188, 92);
            this.GB_OptionJoueur1.TabIndex = 4;
            this.GB_OptionJoueur1.TabStop = false;
            this.GB_OptionJoueur1.Text = "Option J1";
            // 
            // FB_PasserJ1
            // 
            this.FB_PasserJ1.BackgroundImage = global::blackjack.Properties.Resources.check_default;
            this.FB_PasserJ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_PasserJ1.ImageClick = global::blackjack.Properties.Resources.check_click;
            this.FB_PasserJ1.ImageDisable = null;
            this.FB_PasserJ1.ImageNeutral = global::blackjack.Properties.Resources.check_default;
            this.FB_PasserJ1.ImageOver = null;
            this.FB_PasserJ1.Location = new System.Drawing.Point(99, 18);
            this.FB_PasserJ1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_PasserJ1.Name = "FB_PasserJ1";
            this.FB_PasserJ1.Size = new System.Drawing.Size(73, 67);
            this.FB_PasserJ1.TabIndex = 0;
            this.FB_PasserJ1.Click += new System.EventHandler(this.FB_PasserJ1_Click);
            // 
            // FB_PigerJ1
            // 
            this.FB_PigerJ1.BackgroundImage = global::blackjack.Properties.Resources.piger_click;
            this.FB_PigerJ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_PigerJ1.CausesValidation = false;
            this.FB_PigerJ1.ImageClick = global::blackjack.Properties.Resources.piger_default;
            this.FB_PigerJ1.ImageDisable = null;
            this.FB_PigerJ1.ImageNeutral = global::blackjack.Properties.Resources.piger_click;
            this.FB_PigerJ1.ImageOver = null;
            this.FB_PigerJ1.Location = new System.Drawing.Point(12, 18);
            this.FB_PigerJ1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_PigerJ1.Name = "FB_PigerJ1";
            this.FB_PigerJ1.Size = new System.Drawing.Size(73, 67);
            this.FB_PigerJ1.TabIndex = 0;
            this.FB_PigerJ1.Click += new System.EventHandler(this.FB_PigerJ1_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(473, 378);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(69, 23);
            this.BTN_Quitter.TabIndex = 5;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // BTN_Rejouer
            // 
            this.BTN_Rejouer.Location = new System.Drawing.Point(399, 378);
            this.BTN_Rejouer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Rejouer.Name = "BTN_Rejouer";
            this.BTN_Rejouer.Size = new System.Drawing.Size(69, 23);
            this.BTN_Rejouer.TabIndex = 5;
            this.BTN_Rejouer.Text = "Rejouer";
            this.BTN_Rejouer.UseVisualStyleBackColor = true;
            this.BTN_Rejouer.Click += new System.EventHandler(this.BTN_Rejouer_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(326, 378);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(69, 23);
            this.BTN_Annuler.TabIndex = 5;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_AfficherJournalJ1
            // 
            this.BTN_AfficherJournalJ1.Location = new System.Drawing.Point(464, 14);
            this.BTN_AfficherJournalJ1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_AfficherJournalJ1.Name = "BTN_AfficherJournalJ1";
            this.BTN_AfficherJournalJ1.Size = new System.Drawing.Size(69, 23);
            this.BTN_AfficherJournalJ1.TabIndex = 5;
            this.BTN_AfficherJournalJ1.Text = "Journal J1";
            this.BTN_AfficherJournalJ1.UseVisualStyleBackColor = true;
            this.BTN_AfficherJournalJ1.Click += new System.EventHandler(this.BTN_AfficherJournalJ1_Click);
            // 
            // BTN_AfficherJournalJ2
            // 
            this.BTN_AfficherJournalJ2.Location = new System.Drawing.Point(464, 259);
            this.BTN_AfficherJournalJ2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_AfficherJournalJ2.Name = "BTN_AfficherJournalJ2";
            this.BTN_AfficherJournalJ2.Size = new System.Drawing.Size(69, 23);
            this.BTN_AfficherJournalJ2.TabIndex = 5;
            this.BTN_AfficherJournalJ2.Text = "Journal J2";
            this.BTN_AfficherJournalJ2.UseVisualStyleBackColor = true;
            this.BTN_AfficherJournalJ2.Click += new System.EventHandler(this.BTN_AfficherJournalJ2_Click);
            // 
            // LB_Points_J1
            // 
            this.LB_Points_J1.AutoSize = true;
            this.LB_Points_J1.Location = new System.Drawing.Point(136, 135);
            this.LB_Points_J1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Points_J1.Name = "LB_Points_J1";
            this.LB_Points_J1.Size = new System.Drawing.Size(0, 13);
            this.LB_Points_J1.TabIndex = 6;
            this.LB_Points_J1.TextChanged += new System.EventHandler(this.LB_Points_J1_TextChanged);
            // 
            // LB_PointageJ2
            // 
            this.LB_PointageJ2.AutoSize = true;
            this.LB_PointageJ2.Location = new System.Drawing.Point(35, 378);
            this.LB_PointageJ2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_PointageJ2.Name = "LB_PointageJ2";
            this.LB_PointageJ2.Size = new System.Drawing.Size(98, 13);
            this.LB_PointageJ2.TabIndex = 3;
            this.LB_PointageJ2.Text = "Valeur des cartes : ";
            // 
            // LB_Points_J2
            // 
            this.LB_Points_J2.AutoSize = true;
            this.LB_Points_J2.Location = new System.Drawing.Point(135, 378);
            this.LB_Points_J2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Points_J2.Name = "LB_Points_J2";
            this.LB_Points_J2.Size = new System.Drawing.Size(0, 13);
            this.LB_Points_J2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::blackjack.Properties.Resources.Versus;
            this.pictureBox1.Location = new System.Drawing.Point(238, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Jouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 424);
            this.Controls.Add(this.LB_Points_J2);
            this.Controls.Add(this.LB_Points_J1);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Rejouer);
            this.Controls.Add(this.BTN_AfficherJournalJ2);
            this.Controls.Add(this.BTN_AfficherJournalJ1);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.GB_OptionJoueur1);
            this.Controls.Add(this.GB_OptionJoueur2);
            this.Controls.Add(this.LB_PointageJ2);
            this.Controls.Add(this.LB_PointageJ1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_Joueur2);
            this.Controls.Add(this.LB_Joueur1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Jouer";
            this.Text = "Jouer le jeu qui joue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Jouer_FormClosed);
            this.Load += new System.EventHandler(this.Form_Jouer_Load);
            this.GB_OptionJoueur2.ResumeLayout(false);
            this.GB_OptionJoueur1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Joueur1;
        private System.Windows.Forms.Label LB_Joueur2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_PointageJ1;
        private System.Windows.Forms.GroupBox GB_OptionJoueur2;
        private System.Windows.Forms.GroupBox GB_OptionJoueur1;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Button BTN_Rejouer;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_AfficherJournalJ1;
        private System.Windows.Forms.Button BTN_AfficherJournalJ2;
        private System.Windows.Forms.Label LB_Points_J1;
        private System.Windows.Forms.Label LB_PointageJ2;
        private System.Windows.Forms.Label LB_Points_J2;
        private FlashButton.FlashButton FB_PasserJ2;
        private FlashButton.FlashButton FB_PigerJ2;
        private FlashButton.FlashButton FB_PasserJ1;
        private FlashButton.FlashButton FB_PigerJ1;
    }
}