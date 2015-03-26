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
            this.PN_Joueur1 = new System.Windows.Forms.Panel();
            this.flashButton1 = new FlashButton.FlashButton();
            this.PB_J1_Carte2 = new System.Windows.Forms.PictureBox();
            this.PB_J1_Carte1 = new System.Windows.Forms.PictureBox();
            this.LB_Joueur2 = new System.Windows.Forms.Label();
            this.PN_Joueur2 = new System.Windows.Forms.Panel();
            this.LB_PointageJ1 = new System.Windows.Forms.Label();
            this.LB_PointageJ2 = new System.Windows.Forms.Label();
            this.GB_OptionJoueur2 = new System.Windows.Forms.GroupBox();
            this.GB_OptionJoueur1 = new System.Windows.Forms.GroupBox();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.BTN_Rejouer = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_AfficherJournalJ1 = new System.Windows.Forms.Button();
            this.BTN_AfficherJournalJ2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Points_J1 = new System.Windows.Forms.Label();
            this.FB_JouerJ1 = new FlashButton.FlashButton();
            this.FB_JouerJ2 = new FlashButton.FlashButton();
            this.flashButton2 = new FlashButton.FlashButton();
            this.flashButton3 = new FlashButton.FlashButton();
            this.PN_Joueur1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte1)).BeginInit();
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
            // PN_Joueur1
            // 
            this.PN_Joueur1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Joueur1.Controls.Add(this.PB_J1_Carte2);
            this.PN_Joueur1.Controls.Add(this.flashButton1);
            this.PN_Joueur1.Controls.Add(this.PB_J1_Carte1);
            this.PN_Joueur1.Location = new System.Drawing.Point(37, 44);
            this.PN_Joueur1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_Joueur1.MaximumSize = new System.Drawing.Size(497, 87);
            this.PN_Joueur1.MinimumSize = new System.Drawing.Size(497, 87);
            this.PN_Joueur1.Name = "PN_Joueur1";
            this.PN_Joueur1.Size = new System.Drawing.Size(497, 87);
            this.PN_Joueur1.TabIndex = 1;
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::blackjack.Properties.Resources.jouer_default;
            this.flashButton1.ImageDisable = null;
            this.flashButton1.ImageNeutral = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton1.ImageOver = null;
            this.flashButton1.Location = new System.Drawing.Point(360, 13);
            this.flashButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(58, 57);
            this.flashButton1.TabIndex = 1;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // PB_J1_Carte2
            // 
            this.PB_J1_Carte2.Location = new System.Drawing.Point(95, -2);
            this.PB_J1_Carte2.Name = "PB_J1_Carte2";
            this.PB_J1_Carte2.Size = new System.Drawing.Size(76, 87);
            this.PB_J1_Carte2.TabIndex = 1;
            this.PB_J1_Carte2.TabStop = false;
            // 
            // PB_J1_Carte1
            // 
            this.PB_J1_Carte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_J1_Carte1.ImageLocation = "";
            this.PB_J1_Carte1.Location = new System.Drawing.Point(199, -34);
            this.PB_J1_Carte1.Name = "PB_J1_Carte1";
            this.PB_J1_Carte1.Size = new System.Drawing.Size(76, 87);
            this.PB_J1_Carte1.TabIndex = 0;
            this.PB_J1_Carte1.TabStop = false;
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
            // PN_Joueur2
            // 
            this.PN_Joueur2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Joueur2.Location = new System.Drawing.Point(46, 292);
            this.PN_Joueur2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_Joueur2.Name = "PN_Joueur2";
            this.PN_Joueur2.Size = new System.Drawing.Size(497, 79);
            this.PN_Joueur2.TabIndex = 1;
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
            // LB_PointageJ2
            // 
            this.LB_PointageJ2.AutoSize = true;
            this.LB_PointageJ2.Location = new System.Drawing.Point(49, 378);
            this.LB_PointageJ2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_PointageJ2.Name = "LB_PointageJ2";
            this.LB_PointageJ2.Size = new System.Drawing.Size(98, 13);
            this.LB_PointageJ2.TabIndex = 3;
            this.LB_PointageJ2.Text = "Valeur des cartes : ";
            // 
            // GB_OptionJoueur2
            // 
            this.GB_OptionJoueur2.Controls.Add(this.flashButton3);
            this.GB_OptionJoueur2.Controls.Add(this.FB_JouerJ2);
            this.GB_OptionJoueur2.Location = new System.Drawing.Point(510, 245);
            this.GB_OptionJoueur2.Name = "GB_OptionJoueur2";
            this.GB_OptionJoueur2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_OptionJoueur2.Size = new System.Drawing.Size(188, 92);
            this.GB_OptionJoueur2.TabIndex = 4;
            this.GB_OptionJoueur2.TabStop = false;
            this.GB_OptionJoueur2.Text = "Option J2";
            // 
            // GB_OptionJoueur1
            // 
            this.GB_OptionJoueur1.Controls.Add(this.flashButton2);
            this.GB_OptionJoueur1.Controls.Add(this.FB_JouerJ1);
            this.GB_OptionJoueur1.Location = new System.Drawing.Point(69, 245);
            this.GB_OptionJoueur1.Name = "GB_OptionJoueur1";
            this.GB_OptionJoueur1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_OptionJoueur1.Size = new System.Drawing.Size(188, 92);
            this.GB_OptionJoueur1.TabIndex = 4;
            this.GB_OptionJoueur1.TabStop = false;
            this.GB_OptionJoueur1.Text = "Option J1";
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
            // LB_Points_J1
            // 
            this.LB_Points_J1.AutoSize = true;
            this.LB_Points_J1.Location = new System.Drawing.Point(131, 135);
            this.LB_Points_J1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Points_J1.Name = "LB_Points_J1";
            this.LB_Points_J1.Size = new System.Drawing.Size(0, 13);
            this.LB_Points_J1.TabIndex = 6;
            // 
            // FB_JouerJ1
            // 
            this.FB_JouerJ1.BackgroundImage = global::blackjack.Properties.Resources.jouer_click;
            this.FB_JouerJ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_JouerJ1.ImageClick = global::blackjack.Properties.Resources.jouer_default;
            this.FB_JouerJ1.ImageDisable = null;
            this.FB_JouerJ1.ImageNeutral = global::blackjack.Properties.Resources.jouer_click;
            this.FB_JouerJ1.ImageOver = null;
            this.FB_JouerJ1.Location = new System.Drawing.Point(30, 30);
            this.FB_JouerJ1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_JouerJ1.Name = "FB_JouerJ1";
            this.FB_JouerJ1.Size = new System.Drawing.Size(87, 88);
            this.FB_JouerJ1.TabIndex = 1;
            this.FB_JouerJ1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // FB_JouerJ2
            // 
            this.FB_JouerJ2.BackgroundImage = global::blackjack.Properties.Resources.jouer_click;
            this.FB_JouerJ2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_JouerJ2.ImageClick = global::blackjack.Properties.Resources.jouer_default;
            this.FB_JouerJ2.ImageDisable = null;
            this.FB_JouerJ2.ImageNeutral = global::blackjack.Properties.Resources.jouer_click;
            this.FB_JouerJ2.ImageOver = null;
            this.FB_JouerJ2.Location = new System.Drawing.Point(26, 30);
            this.FB_JouerJ2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_JouerJ2.Name = "FB_JouerJ2";
            this.FB_JouerJ2.Size = new System.Drawing.Size(87, 88);
            this.FB_JouerJ2.TabIndex = 1;
            this.FB_JouerJ2.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::blackjack.Properties.Resources.no_deal_default;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton2.ImageClick = global::blackjack.Properties.Resources.jouer_default;
            this.flashButton2.ImageDisable = null;
            this.flashButton2.ImageNeutral = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton2.ImageOver = null;
            this.flashButton2.Location = new System.Drawing.Point(158, 30);
            this.flashButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.Size = new System.Drawing.Size(87, 88);
            this.flashButton2.TabIndex = 1;
            this.flashButton2.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImage = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton3.ImageClick = global::blackjack.Properties.Resources.jouer_default;
            this.flashButton3.ImageDisable = null;
            this.flashButton3.ImageNeutral = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton3.ImageOver = null;
            this.flashButton3.Location = new System.Drawing.Point(157, 30);
            this.flashButton3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.Size = new System.Drawing.Size(87, 88);
            this.flashButton3.TabIndex = 1;
            this.flashButton3.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // Form_Jouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 408);
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
            this.Controls.Add(this.PN_Joueur2);
            this.Controls.Add(this.PN_Joueur1);
            this.Controls.Add(this.LB_Joueur2);
            this.Controls.Add(this.LB_Joueur1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Jouer";
            this.Text = "Jouer le jeu qui joue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Jouer_FormClosed);
            this.Load += new System.EventHandler(this.Form_Jouer_Load);
            this.PN_Joueur1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte1)).EndInit();
            this.GB_OptionJoueur2.ResumeLayout(false);
            this.GB_OptionJoueur1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Joueur1;
        private System.Windows.Forms.Panel PN_Joueur1;
        private System.Windows.Forms.Label LB_Joueur2;
        private System.Windows.Forms.Panel PN_Joueur2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_PointageJ1;
        private System.Windows.Forms.Label LB_PointageJ2;
        private System.Windows.Forms.GroupBox GB_OptionJoueur2;
        private System.Windows.Forms.GroupBox GB_OptionJoueur1;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Button BTN_Rejouer;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_AfficherJournalJ1;
        private System.Windows.Forms.Button BTN_AfficherJournalJ2;
        private FlashButton.FlashButton flashButton1;
        private System.Windows.Forms.PictureBox PB_J1_Carte2;
        private System.Windows.Forms.PictureBox PB_J1_Carte1;
        private System.Windows.Forms.Label LB_Points_J1;
        private FlashButton.FlashButton flashButton3;
        private FlashButton.FlashButton FB_JouerJ2;
        private FlashButton.FlashButton flashButton2;
        private FlashButton.FlashButton FB_JouerJ1;
    }
}