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
            this.PB_J1_Carte2 = new System.Windows.Forms.PictureBox();
            this.flashButton1 = new FlashButton.FlashButton();
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
            this.PN_Joueur1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Joueur1
            // 
            this.LB_Joueur1.AutoSize = true;
            this.LB_Joueur1.Location = new System.Drawing.Point(52, 35);
            this.LB_Joueur1.Name = "LB_Joueur1";
            this.LB_Joueur1.Size = new System.Drawing.Size(67, 20);
            this.LB_Joueur1.TabIndex = 0;
            this.LB_Joueur1.Text = "Joueur1";
            // 
            // PN_Joueur1
            // 
            this.PN_Joueur1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Joueur1.Controls.Add(this.PB_J1_Carte2);
            this.PN_Joueur1.Controls.Add(this.flashButton1);
            this.PN_Joueur1.Controls.Add(this.PB_J1_Carte1);
            this.PN_Joueur1.Location = new System.Drawing.Point(56, 68);
            this.PN_Joueur1.MaximumSize = new System.Drawing.Size(744, 132);
            this.PN_Joueur1.MinimumSize = new System.Drawing.Size(744, 132);
            this.PN_Joueur1.Name = "PN_Joueur1";
            this.PN_Joueur1.Size = new System.Drawing.Size(744, 132);
            this.PN_Joueur1.TabIndex = 1;
            // 
            // PB_J1_Carte2
            // 
            this.PB_J1_Carte2.Location = new System.Drawing.Point(142, -3);
            this.PB_J1_Carte2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_J1_Carte2.Name = "PB_J1_Carte2";
            this.PB_J1_Carte2.Size = new System.Drawing.Size(114, 134);
            this.PB_J1_Carte2.TabIndex = 1;
            this.PB_J1_Carte2.TabStop = false;
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::blackjack.Properties.Resources.jouer_default;
            this.flashButton1.ImageDisable = null;
            this.flashButton1.ImageNeutral = global::blackjack.Properties.Resources.jouer_click;
            this.flashButton1.ImageOver = null;
            this.flashButton1.Location = new System.Drawing.Point(540, 20);
            this.flashButton1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(87, 88);
            this.flashButton1.TabIndex = 1;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // PB_J1_Carte1
            // 
            this.PB_J1_Carte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_J1_Carte1.ImageLocation = "";
            this.PB_J1_Carte1.Location = new System.Drawing.Point(266, -3);
            this.PB_J1_Carte1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_J1_Carte1.Name = "PB_J1_Carte1";
            this.PB_J1_Carte1.Size = new System.Drawing.Size(114, 134);
            this.PB_J1_Carte1.TabIndex = 0;
            this.PB_J1_Carte1.TabStop = false;
            // 
            // LB_Joueur2
            // 
            this.LB_Joueur2.AutoSize = true;
            this.LB_Joueur2.Location = new System.Drawing.Point(52, 408);
            this.LB_Joueur2.Name = "LB_Joueur2";
            this.LB_Joueur2.Size = new System.Drawing.Size(67, 20);
            this.LB_Joueur2.TabIndex = 0;
            this.LB_Joueur2.Text = "Joueur2";
            // 
            // PN_Joueur2
            // 
            this.PN_Joueur2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Joueur2.Location = new System.Drawing.Point(69, 449);
            this.PN_Joueur2.Name = "PN_Joueur2";
            this.PN_Joueur2.Size = new System.Drawing.Size(744, 119);
            this.PN_Joueur2.TabIndex = 1;
            // 
            // LB_PointageJ1
            // 
            this.LB_PointageJ1.AutoSize = true;
            this.LB_PointageJ1.Location = new System.Drawing.Point(52, 208);
            this.LB_PointageJ1.Name = "LB_PointageJ1";
            this.LB_PointageJ1.Size = new System.Drawing.Size(145, 20);
            this.LB_PointageJ1.TabIndex = 3;
            this.LB_PointageJ1.Text = "Valeur des cartes : ";
            // 
            // LB_PointageJ2
            // 
            this.LB_PointageJ2.AutoSize = true;
            this.LB_PointageJ2.Location = new System.Drawing.Point(74, 582);
            this.LB_PointageJ2.Name = "LB_PointageJ2";
            this.LB_PointageJ2.Size = new System.Drawing.Size(145, 20);
            this.LB_PointageJ2.TabIndex = 3;
            this.LB_PointageJ2.Text = "Valeur des cartes : ";
            // 
            // GB_OptionJoueur2
            // 
            this.GB_OptionJoueur2.Location = new System.Drawing.Point(510, 245);
            this.GB_OptionJoueur2.Name = "GB_OptionJoueur2";
            this.GB_OptionJoueur2.Size = new System.Drawing.Size(282, 142);
            this.GB_OptionJoueur2.TabIndex = 4;
            this.GB_OptionJoueur2.TabStop = false;
            this.GB_OptionJoueur2.Text = "Option J2";
            // 
            // GB_OptionJoueur1
            // 
            this.GB_OptionJoueur1.Location = new System.Drawing.Point(69, 245);
            this.GB_OptionJoueur1.Name = "GB_OptionJoueur1";
            this.GB_OptionJoueur1.Size = new System.Drawing.Size(282, 142);
            this.GB_OptionJoueur1.TabIndex = 4;
            this.GB_OptionJoueur1.TabStop = false;
            this.GB_OptionJoueur1.Text = "Option J1";
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(710, 582);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(104, 35);
            this.BTN_Quitter.TabIndex = 5;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // BTN_Rejouer
            // 
            this.BTN_Rejouer.Location = new System.Drawing.Point(598, 582);
            this.BTN_Rejouer.Name = "BTN_Rejouer";
            this.BTN_Rejouer.Size = new System.Drawing.Size(104, 35);
            this.BTN_Rejouer.TabIndex = 5;
            this.BTN_Rejouer.Text = "Rejouer";
            this.BTN_Rejouer.UseVisualStyleBackColor = true;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(489, 582);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(104, 35);
            this.BTN_Annuler.TabIndex = 5;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_AfficherJournalJ1
            // 
            this.BTN_AfficherJournalJ1.Location = new System.Drawing.Point(696, 22);
            this.BTN_AfficherJournalJ1.Name = "BTN_AfficherJournalJ1";
            this.BTN_AfficherJournalJ1.Size = new System.Drawing.Size(104, 35);
            this.BTN_AfficherJournalJ1.TabIndex = 5;
            this.BTN_AfficherJournalJ1.Text = "Journal J1";
            this.BTN_AfficherJournalJ1.UseVisualStyleBackColor = true;
            this.BTN_AfficherJournalJ1.Click += new System.EventHandler(this.BTN_AfficherJournalJ1_Click);
            // 
            // BTN_AfficherJournalJ2
            // 
            this.BTN_AfficherJournalJ2.Location = new System.Drawing.Point(696, 398);
            this.BTN_AfficherJournalJ2.Name = "BTN_AfficherJournalJ2";
            this.BTN_AfficherJournalJ2.Size = new System.Drawing.Size(104, 35);
            this.BTN_AfficherJournalJ2.TabIndex = 5;
            this.BTN_AfficherJournalJ2.Text = "Journal J2";
            this.BTN_AfficherJournalJ2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::blackjack.Properties.Resources.Versus;
            this.pictureBox1.Location = new System.Drawing.Point(357, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LB_Points_J1
            // 
            this.LB_Points_J1.AutoSize = true;
            this.LB_Points_J1.Location = new System.Drawing.Point(196, 208);
            this.LB_Points_J1.Name = "LB_Points_J1";
            this.LB_Points_J1.Size = new System.Drawing.Size(0, 20);
            this.LB_Points_J1.TabIndex = 6;
            this.LB_Points_J1.TextChanged += new System.EventHandler(this.LB_Points_J1_TextChanged);
            // 
            // Form_Jouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 628);
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
            this.Name = "Form_Jouer";
            this.Text = "Jouer le jeu qui joue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Jouer_FormClosed);
            this.Load += new System.EventHandler(this.Form_Jouer_Load);
            this.PN_Joueur1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1_Carte1)).EndInit();
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
    }
}