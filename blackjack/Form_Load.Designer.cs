namespace blackjack
{
    partial class Form_Load
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Load));
            this.Timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.PG_Load = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Timer_Loading
            // 
            this.Timer_Loading.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PG_Load
            // 
            this.PG_Load.Location = new System.Drawing.Point(12, 565);
            this.PG_Load.Name = "PG_Load";
            this.PG_Load.Size = new System.Drawing.Size(764, 23);
            this.PG_Load.TabIndex = 0;
            // 
            // Form_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blackjack.Properties.Resources.Load_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PG_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Load";
            this.Text = "Form_Load";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Load_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Loading;
        private System.Windows.Forms.ProgressBar PG_Load;
    }
}