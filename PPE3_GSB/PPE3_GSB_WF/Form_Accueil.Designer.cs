namespace PPE3_GSB_WF
{
    partial class Form_Accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_Visiteurs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rapports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Medicaments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Medecins = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Visiteurs,
            this.mnu_Rapports,
            this.mnu_Medicaments,
            this.mnu_Medecins});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_Visiteurs
            // 
            this.mnu_Visiteurs.Name = "mnu_Visiteurs";
            this.mnu_Visiteurs.Size = new System.Drawing.Size(63, 20);
            this.mnu_Visiteurs.Text = "Visiteurs";
            this.mnu_Visiteurs.Click += new System.EventHandler(this.visiteursToolStripMenuItem_Click);
            // 
            // mnu_Rapports
            // 
            this.mnu_Rapports.Name = "mnu_Rapports";
            this.mnu_Rapports.Size = new System.Drawing.Size(66, 20);
            this.mnu_Rapports.Text = "Rapports";
            this.mnu_Rapports.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // mnu_Medicaments
            // 
            this.mnu_Medicaments.Name = "mnu_Medicaments";
            this.mnu_Medicaments.Size = new System.Drawing.Size(91, 20);
            this.mnu_Medicaments.Text = "Medicaments";
            this.mnu_Medicaments.Click += new System.EventHandler(this.medicamentsToolStripMenuItem_Click);
            // 
            // mnu_Medecins
            // 
            this.mnu_Medecins.Name = "mnu_Medecins";
            this.mnu_Medecins.Size = new System.Drawing.Size(70, 20);
            this.mnu_Medecins.Text = "Medecins";
            this.mnu_Medecins.Click += new System.EventHandler(this.medecinsToolStripMenuItem_Click);
            // 
            // Form_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form_Accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Visiteurs;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rapports;
        private System.Windows.Forms.ToolStripMenuItem mnu_Medicaments;
        private System.Windows.Forms.ToolStripMenuItem mnu_Medecins;
    }
}