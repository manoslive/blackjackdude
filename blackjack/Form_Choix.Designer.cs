namespace blackjack
{
    partial class Form_Choix
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Choix));
            this.LB_ModeJeu = new System.Windows.Forms.Label();
            this.GB_Joueur1 = new System.Windows.Forms.GroupBox();
            this.GB_J1_TypeIA = new System.Windows.Forms.GroupBox();
            this.GB_J1_NiveauIA = new System.Windows.Forms.Label();
            this.CB_J1_Comptage = new System.Windows.Forms.CheckBox();
            this.RB_J1_Courageux = new System.Windows.Forms.RadioButton();
            this.RB_J1_Moyen = new System.Windows.Forms.RadioButton();
            this.RB_J1_Prudent = new System.Windows.Forms.RadioButton();
            this.GB_J1_TypeJoueur = new System.Windows.Forms.GroupBox();
            this.RB_J1_IA = new System.Windows.Forms.RadioButton();
            this.RB_J1_Humain = new System.Windows.Forms.RadioButton();
            this.GB_Joueur2 = new System.Windows.Forms.GroupBox();
            this.GB_J2_TypeIA = new System.Windows.Forms.GroupBox();
            this.GB_J2_NiveauIA = new System.Windows.Forms.Label();
            this.CB_J2_Comptage = new System.Windows.Forms.CheckBox();
            this.RB_J2_Courageux = new System.Windows.Forms.RadioButton();
            this.RB_J2_Moyen = new System.Windows.Forms.RadioButton();
            this.RB_J2_Prudent = new System.Windows.Forms.RadioButton();
            this.GB_J2_TypeJoueur = new System.Windows.Forms.GroupBox();
            this.RB_J2_IA = new System.Windows.Forms.RadioButton();
            this.RB_J2_Humain = new System.Windows.Forms.RadioButton();
            this.BTN_Jouer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_Joueur1.SuspendLayout();
            this.GB_J1_TypeIA.SuspendLayout();
            this.GB_J1_TypeJoueur.SuspendLayout();
            this.GB_Joueur2.SuspendLayout();
            this.GB_J2_TypeIA.SuspendLayout();
            this.GB_J2_TypeJoueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ModeJeu
            // 
            this.LB_ModeJeu.AutoSize = true;
            this.LB_ModeJeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ModeJeu.Location = new System.Drawing.Point(124, 9);
            this.LB_ModeJeu.Name = "LB_ModeJeu";
            this.LB_ModeJeu.Size = new System.Drawing.Size(518, 55);
            this.LB_ModeJeu.TabIndex = 0;
            this.LB_ModeJeu.Text = "Choisir un mode de jeu";
            this.LB_ModeJeu.Click += new System.EventHandler(this.label1_Click);
            // 
            // GB_Joueur1
            // 
            this.GB_Joueur1.Controls.Add(this.GB_J1_TypeIA);
            this.GB_Joueur1.Controls.Add(this.GB_J1_TypeJoueur);
            this.GB_Joueur1.Location = new System.Drawing.Point(13, 67);
            this.GB_Joueur1.Name = "GB_Joueur1";
            this.GB_Joueur1.Size = new System.Drawing.Size(260, 430);
            this.GB_Joueur1.TabIndex = 3;
            this.GB_Joueur1.TabStop = false;
            this.GB_Joueur1.Text = "Joueur1";
            // 
            // GB_J1_TypeIA
            // 
            this.GB_J1_TypeIA.Controls.Add(this.GB_J1_NiveauIA);
            this.GB_J1_TypeIA.Controls.Add(this.CB_J1_Comptage);
            this.GB_J1_TypeIA.Controls.Add(this.RB_J1_Courageux);
            this.GB_J1_TypeIA.Controls.Add(this.RB_J1_Moyen);
            this.GB_J1_TypeIA.Controls.Add(this.RB_J1_Prudent);
            this.GB_J1_TypeIA.Location = new System.Drawing.Point(18, 171);
            this.GB_J1_TypeIA.Name = "GB_J1_TypeIA";
            this.GB_J1_TypeIA.Size = new System.Drawing.Size(200, 246);
            this.GB_J1_TypeIA.TabIndex = 1;
            this.GB_J1_TypeIA.TabStop = false;
            this.GB_J1_TypeIA.Text = "Type de joueur";
            // 
            // GB_J1_NiveauIA
            // 
            this.GB_J1_NiveauIA.AutoSize = true;
            this.GB_J1_NiveauIA.Location = new System.Drawing.Point(6, 101);
            this.GB_J1_NiveauIA.Name = "GB_J1_NiveauIA";
            this.GB_J1_NiveauIA.Size = new System.Drawing.Size(105, 20);
            this.GB_J1_NiveauIA.TabIndex = 2;
            this.GB_J1_NiveauIA.Text = "Niveau de l\'IA";
            // 
            // CB_J1_Comptage
            // 
            this.CB_J1_Comptage.AutoSize = true;
            this.CB_J1_Comptage.Enabled = false;
            this.CB_J1_Comptage.Location = new System.Drawing.Point(7, 38);
            this.CB_J1_Comptage.Name = "CB_J1_Comptage";
            this.CB_J1_Comptage.Size = new System.Drawing.Size(168, 24);
            this.CB_J1_Comptage.TabIndex = 1;
            this.CB_J1_Comptage.Text = "Compter les cartes";
            this.CB_J1_Comptage.UseVisualStyleBackColor = true;
            this.CB_J1_Comptage.CheckedChanged += new System.EventHandler(this.CB_J1_Comptage_CheckedChanged);
            // 
            // RB_J1_Courageux
            // 
            this.RB_J1_Courageux.AutoSize = true;
            this.RB_J1_Courageux.Enabled = false;
            this.RB_J1_Courageux.Location = new System.Drawing.Point(21, 206);
            this.RB_J1_Courageux.Name = "RB_J1_Courageux";
            this.RB_J1_Courageux.Size = new System.Drawing.Size(111, 24);
            this.RB_J1_Courageux.TabIndex = 0;
            this.RB_J1_Courageux.TabStop = true;
            this.RB_J1_Courageux.Text = "Courageux";
            this.RB_J1_Courageux.UseVisualStyleBackColor = true;
            this.RB_J1_Courageux.CheckedChanged += new System.EventHandler(this.RB_J1_Courageux_CheckedChanged);
            // 
            // RB_J1_Moyen
            // 
            this.RB_J1_Moyen.AutoSize = true;
            this.RB_J1_Moyen.Enabled = false;
            this.RB_J1_Moyen.Location = new System.Drawing.Point(21, 176);
            this.RB_J1_Moyen.Name = "RB_J1_Moyen";
            this.RB_J1_Moyen.Size = new System.Drawing.Size(81, 24);
            this.RB_J1_Moyen.TabIndex = 0;
            this.RB_J1_Moyen.TabStop = true;
            this.RB_J1_Moyen.Text = "Moyen";
            this.RB_J1_Moyen.UseVisualStyleBackColor = true;
            this.RB_J1_Moyen.CheckedChanged += new System.EventHandler(this.RB_J1_Moyen_CheckedChanged);
            // 
            // RB_J1_Prudent
            // 
            this.RB_J1_Prudent.AutoSize = true;
            this.RB_J1_Prudent.Enabled = false;
            this.RB_J1_Prudent.Location = new System.Drawing.Point(21, 146);
            this.RB_J1_Prudent.Name = "RB_J1_Prudent";
            this.RB_J1_Prudent.Size = new System.Drawing.Size(90, 24);
            this.RB_J1_Prudent.TabIndex = 0;
            this.RB_J1_Prudent.TabStop = true;
            this.RB_J1_Prudent.Text = "Prudent";
            this.RB_J1_Prudent.UseVisualStyleBackColor = true;
            this.RB_J1_Prudent.CheckedChanged += new System.EventHandler(this.RB_J1_Prudent_CheckedChanged);
            // 
            // GB_J1_TypeJoueur
            // 
            this.GB_J1_TypeJoueur.Controls.Add(this.RB_J1_IA);
            this.GB_J1_TypeJoueur.Controls.Add(this.RB_J1_Humain);
            this.GB_J1_TypeJoueur.Location = new System.Drawing.Point(18, 38);
            this.GB_J1_TypeJoueur.Name = "GB_J1_TypeJoueur";
            this.GB_J1_TypeJoueur.Size = new System.Drawing.Size(200, 100);
            this.GB_J1_TypeJoueur.TabIndex = 1;
            this.GB_J1_TypeJoueur.TabStop = false;
            this.GB_J1_TypeJoueur.Text = "Type de joueur";
            // 
            // RB_J1_IA
            // 
            this.RB_J1_IA.AutoSize = true;
            this.RB_J1_IA.Location = new System.Drawing.Point(6, 61);
            this.RB_J1_IA.Name = "RB_J1_IA";
            this.RB_J1_IA.Size = new System.Drawing.Size(50, 24);
            this.RB_J1_IA.TabIndex = 0;
            this.RB_J1_IA.TabStop = true;
            this.RB_J1_IA.Text = "IA";
            this.RB_J1_IA.UseVisualStyleBackColor = true;
            this.RB_J1_IA.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RB_J1_Humain
            // 
            this.RB_J1_Humain.AutoSize = true;
            this.RB_J1_Humain.Checked = true;
            this.RB_J1_Humain.Location = new System.Drawing.Point(6, 31);
            this.RB_J1_Humain.Name = "RB_J1_Humain";
            this.RB_J1_Humain.Size = new System.Drawing.Size(89, 24);
            this.RB_J1_Humain.TabIndex = 0;
            this.RB_J1_Humain.TabStop = true;
            this.RB_J1_Humain.Text = "Humain";
            this.RB_J1_Humain.UseVisualStyleBackColor = true;
            this.RB_J1_Humain.CheckedChanged += new System.EventHandler(this.RB_J1_Humain_CheckedChanged);
            // 
            // GB_Joueur2
            // 
            this.GB_Joueur2.Controls.Add(this.GB_J2_TypeIA);
            this.GB_Joueur2.Controls.Add(this.GB_J2_TypeJoueur);
            this.GB_Joueur2.Location = new System.Drawing.Point(473, 67);
            this.GB_Joueur2.Name = "GB_Joueur2";
            this.GB_Joueur2.Size = new System.Drawing.Size(260, 430);
            this.GB_Joueur2.TabIndex = 3;
            this.GB_Joueur2.TabStop = false;
            this.GB_Joueur2.Text = "Joueur2";
            // 
            // GB_J2_TypeIA
            // 
            this.GB_J2_TypeIA.Controls.Add(this.GB_J2_NiveauIA);
            this.GB_J2_TypeIA.Controls.Add(this.CB_J2_Comptage);
            this.GB_J2_TypeIA.Controls.Add(this.RB_J2_Courageux);
            this.GB_J2_TypeIA.Controls.Add(this.RB_J2_Moyen);
            this.GB_J2_TypeIA.Controls.Add(this.RB_J2_Prudent);
            this.GB_J2_TypeIA.Location = new System.Drawing.Point(19, 171);
            this.GB_J2_TypeIA.Name = "GB_J2_TypeIA";
            this.GB_J2_TypeIA.Size = new System.Drawing.Size(200, 246);
            this.GB_J2_TypeIA.TabIndex = 1;
            this.GB_J2_TypeIA.TabStop = false;
            this.GB_J2_TypeIA.Text = "Type de joueur";
            // 
            // GB_J2_NiveauIA
            // 
            this.GB_J2_NiveauIA.AutoSize = true;
            this.GB_J2_NiveauIA.Location = new System.Drawing.Point(6, 101);
            this.GB_J2_NiveauIA.Name = "GB_J2_NiveauIA";
            this.GB_J2_NiveauIA.Size = new System.Drawing.Size(105, 20);
            this.GB_J2_NiveauIA.TabIndex = 2;
            this.GB_J2_NiveauIA.Text = "Niveau de l\'IA";
            // 
            // CB_J2_Comptage
            // 
            this.CB_J2_Comptage.AutoSize = true;
            this.CB_J2_Comptage.Enabled = false;
            this.CB_J2_Comptage.Location = new System.Drawing.Point(7, 38);
            this.CB_J2_Comptage.Name = "CB_J2_Comptage";
            this.CB_J2_Comptage.Size = new System.Drawing.Size(168, 24);
            this.CB_J2_Comptage.TabIndex = 1;
            this.CB_J2_Comptage.Text = "Compter les cartes";
            this.CB_J2_Comptage.UseVisualStyleBackColor = true;
            this.CB_J2_Comptage.CheckedChanged += new System.EventHandler(this.CB_J2_Comptage_CheckedChanged);
            // 
            // RB_J2_Courageux
            // 
            this.RB_J2_Courageux.AutoSize = true;
            this.RB_J2_Courageux.Enabled = false;
            this.RB_J2_Courageux.Location = new System.Drawing.Point(21, 206);
            this.RB_J2_Courageux.Name = "RB_J2_Courageux";
            this.RB_J2_Courageux.Size = new System.Drawing.Size(111, 24);
            this.RB_J2_Courageux.TabIndex = 0;
            this.RB_J2_Courageux.TabStop = true;
            this.RB_J2_Courageux.Text = "Courageux";
            this.RB_J2_Courageux.UseVisualStyleBackColor = true;
            this.RB_J2_Courageux.CheckedChanged += new System.EventHandler(this.RB_J2_Courageux_CheckedChanged);
            // 
            // RB_J2_Moyen
            // 
            this.RB_J2_Moyen.AutoSize = true;
            this.RB_J2_Moyen.Enabled = false;
            this.RB_J2_Moyen.Location = new System.Drawing.Point(21, 176);
            this.RB_J2_Moyen.Name = "RB_J2_Moyen";
            this.RB_J2_Moyen.Size = new System.Drawing.Size(81, 24);
            this.RB_J2_Moyen.TabIndex = 0;
            this.RB_J2_Moyen.TabStop = true;
            this.RB_J2_Moyen.Text = "Moyen";
            this.RB_J2_Moyen.UseVisualStyleBackColor = true;
            this.RB_J2_Moyen.CheckedChanged += new System.EventHandler(this.RB_J2_Moyen_CheckedChanged);
            // 
            // RB_J2_Prudent
            // 
            this.RB_J2_Prudent.AutoSize = true;
            this.RB_J2_Prudent.Enabled = false;
            this.RB_J2_Prudent.Location = new System.Drawing.Point(21, 146);
            this.RB_J2_Prudent.Name = "RB_J2_Prudent";
            this.RB_J2_Prudent.Size = new System.Drawing.Size(90, 24);
            this.RB_J2_Prudent.TabIndex = 0;
            this.RB_J2_Prudent.TabStop = true;
            this.RB_J2_Prudent.Text = "Prudent";
            this.RB_J2_Prudent.UseVisualStyleBackColor = true;
            this.RB_J2_Prudent.CheckedChanged += new System.EventHandler(this.RB_J2_Prudent_CheckedChanged);
            // 
            // GB_J2_TypeJoueur
            // 
            this.GB_J2_TypeJoueur.Controls.Add(this.RB_J2_IA);
            this.GB_J2_TypeJoueur.Controls.Add(this.RB_J2_Humain);
            this.GB_J2_TypeJoueur.Location = new System.Drawing.Point(19, 38);
            this.GB_J2_TypeJoueur.Name = "GB_J2_TypeJoueur";
            this.GB_J2_TypeJoueur.Size = new System.Drawing.Size(200, 100);
            this.GB_J2_TypeJoueur.TabIndex = 1;
            this.GB_J2_TypeJoueur.TabStop = false;
            this.GB_J2_TypeJoueur.Text = "Type de joueur";
            // 
            // RB_J2_IA
            // 
            this.RB_J2_IA.AutoSize = true;
            this.RB_J2_IA.Location = new System.Drawing.Point(6, 61);
            this.RB_J2_IA.Name = "RB_J2_IA";
            this.RB_J2_IA.Size = new System.Drawing.Size(50, 24);
            this.RB_J2_IA.TabIndex = 0;
            this.RB_J2_IA.Text = "IA";
            this.RB_J2_IA.UseVisualStyleBackColor = true;
            this.RB_J2_IA.CheckedChanged += new System.EventHandler(this.RB_J2_IA_CheckedChanged);
            // 
            // RB_J2_Humain
            // 
            this.RB_J2_Humain.AutoSize = true;
            this.RB_J2_Humain.Checked = true;
            this.RB_J2_Humain.Location = new System.Drawing.Point(6, 31);
            this.RB_J2_Humain.Name = "RB_J2_Humain";
            this.RB_J2_Humain.Size = new System.Drawing.Size(89, 24);
            this.RB_J2_Humain.TabIndex = 0;
            this.RB_J2_Humain.TabStop = true;
            this.RB_J2_Humain.Text = "Humain";
            this.RB_J2_Humain.UseVisualStyleBackColor = true;
            this.RB_J2_Humain.CheckedChanged += new System.EventHandler(this.RB_J2_Humain_CheckedChanged);
            // 
            // BTN_Jouer
            // 
            this.BTN_Jouer.Location = new System.Drawing.Point(617, 503);
            this.BTN_Jouer.Name = "BTN_Jouer";
            this.BTN_Jouer.Size = new System.Drawing.Size(116, 34);
            this.BTN_Jouer.TabIndex = 4;
            this.BTN_Jouer.Text = "Jouer";
            this.BTN_Jouer.UseVisualStyleBackColor = true;
            this.BTN_Jouer.Click += new System.EventHandler(this.BTN_Jouer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::blackjack.Properties.Resources.Versus;
            this.pictureBox1.Location = new System.Drawing.Point(294, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 549);
            this.Controls.Add(this.BTN_Jouer);
            this.Controls.Add(this.GB_Joueur2);
            this.Controls.Add(this.GB_Joueur1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_ModeJeu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Choix";
            this.Text = "BlackJack";
            this.GB_Joueur1.ResumeLayout(false);
            this.GB_J1_TypeIA.ResumeLayout(false);
            this.GB_J1_TypeIA.PerformLayout();
            this.GB_J1_TypeJoueur.ResumeLayout(false);
            this.GB_J1_TypeJoueur.PerformLayout();
            this.GB_Joueur2.ResumeLayout(false);
            this.GB_J2_TypeIA.ResumeLayout(false);
            this.GB_J2_TypeIA.PerformLayout();
            this.GB_J2_TypeJoueur.ResumeLayout(false);
            this.GB_J2_TypeJoueur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ModeJeu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GB_Joueur1;
        private System.Windows.Forms.GroupBox GB_J1_TypeJoueur;
        private System.Windows.Forms.RadioButton RB_J1_IA;
        private System.Windows.Forms.RadioButton RB_J1_Humain;
        private System.Windows.Forms.GroupBox GB_Joueur2;
        private System.Windows.Forms.GroupBox GB_J2_TypeIA;
        private System.Windows.Forms.RadioButton RB_J2_Moyen;
        private System.Windows.Forms.RadioButton RB_J2_Prudent;
        private System.Windows.Forms.GroupBox GB_J2_TypeJoueur;
        private System.Windows.Forms.RadioButton RB_J2_IA;
        private System.Windows.Forms.RadioButton RB_J2_Humain;
        private System.Windows.Forms.GroupBox GB_J1_TypeIA;
        private System.Windows.Forms.Label GB_J1_NiveauIA;
        private System.Windows.Forms.CheckBox CB_J1_Comptage;
        private System.Windows.Forms.RadioButton RB_J1_Courageux;
        private System.Windows.Forms.RadioButton RB_J1_Moyen;
        private System.Windows.Forms.RadioButton RB_J1_Prudent;
        private System.Windows.Forms.Label GB_J2_NiveauIA;
        private System.Windows.Forms.CheckBox CB_J2_Comptage;
        private System.Windows.Forms.RadioButton RB_J2_Courageux;
        private System.Windows.Forms.Button BTN_Jouer;
    }
}

